using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.main.repository
{
    public interface IRepository<ID, T>
    {
        /**
        * Find the entity with the given {@code id}.
        *
        * @param id
        *            must be not null.
        * 
        */
        T findOne(ID id);

        /**
         *
         * @return all entities.
         */
        List<T> findAll();

        /**
         * Saves the given entity.
         *
         * @param entity
         *            must not be null.
         * 
         */
        void save(T entity);

        /**
         * Removes the entity with the given id.
         *
         * @param id
         *            must not be null.
         */
        void delete(ID id);

        /**
         * Updates the given entity.
         *
         * @param entity
         *            must not be null.
         * 
         * @throws ValidatorException
         *             if the entity is not valid.
         */
        void update(T entity);
    }
}
