namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OptionalDataException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OptionalDataException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _length6231;
		public int length
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _length6231);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _eof6232;
		public bool eof
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _eof6232);
			}
			set
			{
			}
		}
		static OptionalDataException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OptionalDataException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OptionalDataException"));
			global::java.io.OptionalDataException._length6231 = @__env.GetFieldIDNoThrow(global::java.io.OptionalDataException.staticClass, "length", "I");
			global::java.io.OptionalDataException._eof6232 = @__env.GetFieldIDNoThrow(global::java.io.OptionalDataException.staticClass, "eof", "Z");
		}
	}
}
