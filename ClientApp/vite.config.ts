import { defineConfig, loadEnv } from 'vite'
import basicSsl from '@vitejs/plugin-basic-ssl'
import vue from '@vitejs/plugin-vue'

const PORT_FOR_PROXY = process.env.ASPNETCORE_HTTPS_PORT
export default defineConfig({
    plugins: [vue(), basicSsl()],
    server: {
        https: true,
        proxy: {
            '/api': {
                target: `https://localhost:${PORT_FOR_PROXY}`,
                secure: false
            }
        }
    }
})
