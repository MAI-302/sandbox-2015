require 'matrix'
mas = []
puts "Введите n:"
n = gets.to_i
(0...n).each do |i|
	mas[i] = Array.new(n.to_i){rand(100)-rand(100)}
end
0.upto(mas.size - 1) { |i| p mas[i] }
print "Является ли матрица скалярной? - "
puts Matrix.scalar(mas.size, mas[0][0]) == Matrix[*mas]

