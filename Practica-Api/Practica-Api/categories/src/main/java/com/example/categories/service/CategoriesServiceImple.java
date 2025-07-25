package com.example.categories.service;

import com.example.categories.models.entities.Category;
import com.example.categories.repositories.CategoriesRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CategoriesServiceImple implements CategoriesService {

    private final CategoriesRepository categoriesRepository;

    public CategoriesServiceImple(CategoriesRepository categoriesRepository) {
        this.categoriesRepository = categoriesRepository;
    }

    @Override
    public List<Category> getAllCategories() {
        return (List<Category>) categoriesRepository.findAll();
    }

    @Override
    public Optional<Category> getCategoryById(Long id) {
        return categoriesRepository.findById(id);
    }

    @Override
    public Category createCategory(Category category) {
        return categoriesRepository.save(category);
    }

    @Override
    public Category updateCategory(Long id, Category category) {
        if (!categoriesRepository.findById(id).isPresent()) {
            throw new IllegalArgumentException("Category with id " + id + " does not exist");
        }
        category.setId(id);
        return categoriesRepository.save(category);
    }

    @Override
    public void deleteCategory(Long id) {
        if (!categoriesRepository.findById(id).isPresent()) {
            throw new IllegalArgumentException("Category with id " + id + " does not exist");
        }
        categoriesRepository.deleteById(id);
    }
}
