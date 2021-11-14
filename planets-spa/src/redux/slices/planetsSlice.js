import { createSlice } from '@reduxjs/toolkit'

export const counterSlice = createSlice({
  name: 'counter',
  initialState: {
    planets: []
  },
  reducers: {
    setPlanets: (state, action) => (state = {...state, planets: [...action.payload]}),
  },
})

// Action creators are generated for each case reducer function
export const { setPlanets } = counterSlice.actions

export default counterSlice.reducer