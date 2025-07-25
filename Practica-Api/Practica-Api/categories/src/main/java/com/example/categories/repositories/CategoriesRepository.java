package com.example.categories.repositories;

import com.example.categories.models.entities.Category;
import org.springframework.data.repository.CrudRepository;

public interface CategoriesRepository extends CrudRepository<Category, Long> {
    // Aquí puedes agregar métodos personalizados si deseas más adelante
}
