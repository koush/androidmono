namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CharArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharArrayBuffer()
		{
			InitJNI();
		}
		internal CharArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayBuffer4406;
		public CharArrayBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CharArrayBuffer.staticClass, global::android.database.CharArrayBuffer._CharArrayBuffer4406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayBuffer4407;
		public CharArrayBuffer(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CharArrayBuffer.staticClass, global::android.database.CharArrayBuffer._CharArrayBuffer4407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _data4408;
		public char[] data
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetObjectField(this.JvmHandle, _data4408)) as char[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sizeCopied4409;
		public int sizeCopied
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _sizeCopied4409);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CharArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CharArrayBuffer"));
			global::android.database.CharArrayBuffer._CharArrayBuffer4406 = @__env.GetMethodIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "<init>", "(I)V");
			global::android.database.CharArrayBuffer._CharArrayBuffer4407 = @__env.GetMethodIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "<init>", "([C)V");
			global::android.database.CharArrayBuffer._data4408 = @__env.GetFieldIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "data", "[C");
			global::android.database.CharArrayBuffer._sizeCopied4409 = @__env.GetFieldIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "sizeCopied", "I");
		}
	}
}
