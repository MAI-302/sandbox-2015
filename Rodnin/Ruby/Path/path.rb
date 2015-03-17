input = File.open("input.txt") {|file| file.read}
i = 0
input_array = []
input.split("\n").each do |str| 
	input_array[i] = str.split(' ').map! {|ch| ch.to_i}
    i += 1
end

path = [0]
level = 1
    path << input_array[level].index(input_array[level].max)
level = 2
while level < input_array.count do
      path << input_array[level].index([input_array[level][path[level-1]],input_array[level][path[level-1]+1]].max)
      level += 1
end

maxSum = input_array[0][0]
(1...input_array.count.to_i).each do |i|
	maxSum += input_array[i][path[i]]
end

print "Максимальная сумма по оптимальному пути: "
puts maxSum
puts "Индексы оптимального пути:"
p path


