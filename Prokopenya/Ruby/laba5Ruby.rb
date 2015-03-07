require 'matrix'

mas = []
puts "Введите размерность матрицы n:"
n = gets.to_i

(0...n).each do |i|
	mas[i] = Array.new(n.to_i){rand(10)}
end

0.upto(mas.size - 1) { |i| p mas[i] }

p Matrix[*mas].det


