import { configureStore } from '@reduxjs/toolkit'
import planetsReducer from './slices/planetsSlice'

export default configureStore({
  reducer: {
      planetsStore: planetsReducer
  },
})