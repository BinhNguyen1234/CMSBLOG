import { defineConfig, loadEnv } from 'vite'
import basicSsl from '@vitejs/plugin-basic-ssl'
import vue from '@vitejs/plugin-vue'
let a = process.env;
// https://vitejs.dev/config/
export default defineConfig({
    plugins: [vue(), basicSsl()],
    server: {
        https: true
    }
})
console.debug('[vite] connecting...', a);