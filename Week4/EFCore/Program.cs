using EFCore.Entities;
using EFCore.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entity Framework Core - InMemory");

        using (var _context = new NoteMasterDbContext())
        {
            // Toplu ekleme işlemi
            var newNotes = new List<Note>
                {
                    new Note("Note 1"),
                    new Note("Note 2"),
                    new Note("Note 3")
                };
            _context.Notes.AddRange(newNotes);
            _context.SaveChanges();

            // Kayıtları listeleme
            List<Note> notesBeforeDeletion = _context.Notes.ToList();
            Console.WriteLine("Kayıtlar Eklemeden Önce:");
            foreach (var note in notesBeforeDeletion)
            {
                Console.WriteLine($"Id: {note.Id}, Text: {note.Text}");
            }

            // Silme işlemi
            var noteToDelete = _context.Notes.FirstOrDefault(n => n.Text == "Note 2");
            if (noteToDelete != null)
            {
                _context.Notes.Remove(noteToDelete);
                _context.SaveChanges();
            }

            // Güncelleme işlemi
            var noteToUpdate = _context.Notes.FirstOrDefault(n => n.Text == "Note 3");
            if (noteToUpdate != null)
            {
                noteToUpdate.Text = "Updated Note 3";
                _context.SaveChanges();
            }

            // Kayıtları listeleme
            List<Note> notesAfterOperations = _context.Notes.ToList();
            Console.WriteLine("\nKayıtlar Ekleme, Silme ve Güncellemeden Sonra:");
            foreach (var note in notesAfterOperations)
            {
                Console.WriteLine($"Id: {note.Id}, Text: {note.Text}");
            }
        }
    }
}


/*
Console.WriteLine("Entity Framework Core - InMemory");

NoteMasterDbContext _context = new();

_context.Notes.Add(new("Note 1"));
_context.Notes.Add(new("Note 2"));
_context.Notes.Add(new("Note 3"));

_context.SaveChanges();
List<Note> notes = _context.Notes.ToList();

Console.WriteLine();*/
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entity Framework Core - InMemory");

        using (var _context = new NoteMasterDbContext())
        {
            // Kategorileri ekleyelim
            var categories = new List<Category>
                {
                    new Category { Name = "Work" },
                    new Category { Name = "Personal" }
                };
            _context.Categories.AddRange(categories);
            _context.SaveChanges();

            // Notları ve kategorileri ilişkilendirelim
            var workCategory = _context.Categories.FirstOrDefault(c => c.Name == "Work");
            var personalCategory = _context.Categories.FirstOrDefault(c => c.Name == "Personal");

            var notes = new List<Note>
                {
                    new Note { Text = "Work Note 1", CategoryId = workCategory.Id },
                    new Note { Text = "Personal Note 1", CategoryId = personalCategory.Id },
                    new Note { Text = "Work Note 2", CategoryId = workCategory.Id }
                };
            _context.Notes.AddRange(notes);
            _context.SaveChanges();

            // Tüm notları ve kategorileri listeleme
            Console.WriteLine("\nTüm Notlar:");
            var allNotes = _context.Notes.Include(n => n.Category).ToList();
            foreach (var note in allNotes)
            {
                Console.WriteLine($"Id: {note.Id}, Text: {note.Text}, Category: {note.Category.Name}");
            }

            // Bir not güncelleme
            var noteToUpdate = _context.Notes.FirstOrDefault(n => n.Text == "Work Note 1");
            if (noteToUpdate != null)
            {
                noteToUpdate.Text = "Updated Work Note 1";
                _context.SaveChanges();
            }

            // Bir not silme
            var noteToDelete = _context.Notes.FirstOrDefault(n => n.Text == "Personal Note 1");
            if (noteToDelete != null)
            {
                _context.Notes.Remove(noteToDelete);
                _context.SaveChanges();
            }

            // Güncellenmiş ve silinmiş notları gösterme
            Console.WriteLine("\nNotlar Güncellemeden ve Silmeden Sonra:");
            var updatedNotes = _context.Notes.Include(n => n.Category).ToList();
            foreach (var note in updatedNotes)
            {
                Console.WriteLine($"Id: {note.Id}, Text: {note.Text}, Category: {note.Category.Name}");
            }
        }
    }
}*/
