namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CharArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CharArrayBuffer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CharArrayBuffer._m0.native == global::System.IntPtr.Zero)
				global::android.database.CharArrayBuffer._m0 = @__env.GetMethodIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CharArrayBuffer.staticClass, global::android.database.CharArrayBuffer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CharArrayBuffer(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CharArrayBuffer._m1.native == global::System.IntPtr.Zero)
				global::android.database.CharArrayBuffer._m1 = @__env.GetMethodIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CharArrayBuffer.staticClass, global::android.database.CharArrayBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _data2194;
		public char[] data
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetObjectField(this.JvmHandle, _data2194)) as char[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sizeCopied2195;
		public int sizeCopied
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _sizeCopied2195);
			}
			set
			{
			}
		}
		static CharArrayBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CharArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CharArrayBuffer"));
			global::android.database.CharArrayBuffer._data2194 = @__env.GetFieldIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "data", "[C");
			global::android.database.CharArrayBuffer._sizeCopied2195 = @__env.GetFieldIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "sizeCopied", "I");
		}
	}
}
