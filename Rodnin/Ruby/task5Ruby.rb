require 'matrix'
puts "Задайте размер матрицы n:"
n = gets.to_i
mas = []
(0...n).each do |i|
	mas[i] = Array.new(n.to_i){rand(10)-rand(10)}
end
0.upto(mas.size - 1) { |i| p mas[i] }
print "Определитель матрицы  = "
print Matrix[*arr].det