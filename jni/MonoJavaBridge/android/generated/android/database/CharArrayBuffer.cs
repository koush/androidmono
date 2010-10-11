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
		internal static global::MonoJavaBridge.MethodId _CharArrayBuffer2508;
		public CharArrayBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CharArrayBuffer.staticClass, global::android.database.CharArrayBuffer._CharArrayBuffer2508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayBuffer2509;
		public CharArrayBuffer(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CharArrayBuffer.staticClass, global::android.database.CharArrayBuffer._CharArrayBuffer2509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _data2510;
		public char[] data
		{
			get
			{
				return default(char[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sizeCopied2511;
		public int sizeCopied
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CharArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CharArrayBuffer"));
			global::android.database.CharArrayBuffer._CharArrayBuffer2508 = @__env.GetMethodIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "<init>", "(I)V");
			global::android.database.CharArrayBuffer._CharArrayBuffer2509 = @__env.GetMethodIDNoThrow(global::android.database.CharArrayBuffer.staticClass, "<init>", "([C)V");
		}
	}
}
