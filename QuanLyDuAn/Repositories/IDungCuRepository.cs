﻿using QuanLyDuAn.Data;

namespace QuanLyDuAn.Repositories
{
    public interface IDungCuRepository 
    {
        public Task<List<DungCu>> GetDungCus();
        public Task<DungCu> GetDungCuById(string id);
        public Task<string> themDungCu(DungCu model);
        public Task suaDungCu(string id, DungCu model);
        public Task xoaDungCu(string id);
    }
}