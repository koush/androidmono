namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OptionalDataException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OptionalDataException()
		{
			InitJNI();
		}
		protected OptionalDataException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _length19350;
		public int length
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _length19350);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _eof19351;
		public bool eof
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _eof19351);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OptionalDataException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OptionalDataException"));
			global::java.io.OptionalDataException._length19350 = @__env.GetFieldIDNoThrow(global::java.io.OptionalDataException.staticClass, "length", "I");
			global::java.io.OptionalDataException._eof19351 = @__env.GetFieldIDNoThrow(global::java.io.OptionalDataException.staticClass, "eof", "Z");
		}
	}
}
