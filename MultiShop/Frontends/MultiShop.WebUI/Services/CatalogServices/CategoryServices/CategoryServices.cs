﻿using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;

namespace MultiShop.WebUI.Services.CatalogServices.CategoryServices
{
	public class CategoryServices : ICategoryService
	{
		private readonly HttpClient _httpClient;

		public CategoryServices(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
		{
			 await _httpClient.PostAsJsonAsync<CreateCategoryDto>("categories",createCategoryDto);
		}

		public async Task DeleteCategoryAsync(string id)
		{
			await _httpClient.DeleteAsync("categories?id=" + id);
		}

		public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
		{
			var responseMessage = await _httpClient.GetAsync("categories");
			var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultCategoryDto>>();
			return values;
		}

		public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
		{
			var responseMessage = await _httpClient.GetAsync("categories/"+id);
			var values = await responseMessage.Content.ReadFromJsonAsync<GetByIdCategoryDto>();
			return values;
		}

		public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
		{
			await _httpClient.PutAsJsonAsync<UpdateCategoryDto>("categories", updateCategoryDto);
		}
	}
}
