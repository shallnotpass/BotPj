from transformers import AutoTokenizer, AutoModelForSeq2SeqLM
import sys

tokenizer = AutoTokenizer.from_pretrained("facebook/blenderbot_small-90M")

model = AutoModelForSeq2SeqLM.from_pretrained("facebook/blenderbot_small-90M")

UTTERANCE = sys.argv[1]#"My friends are cool but they eat too many carbs."
#print("Human: ", UTTERANCE)
inputs = tokenizer([UTTERANCE], return_tensors='pt')
#inputs.pop("token_type_ids")
reply_ids = model.generate(**inputs)
print( tokenizer.batch_decode(reply_ids, skip_special_tokens=True)[0])#"Bot: ",