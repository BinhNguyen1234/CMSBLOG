import { defineConfig, loadEnv } from 'vite'
import vue from '@vitejs/plugin-vue'
import dotenv from 'dotenv'
// https://vitejs.dev/config/
const config = dotenv.config();
export default defineConfig({
    plugins: [vue()]
})
console.debug('[vite] connecting...', config.parsed);