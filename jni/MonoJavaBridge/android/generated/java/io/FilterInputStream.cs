namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FilterInputStream : java.io.InputStream
	{
		internal static global::java.lang.Class staticClass;
		static FilterInputStream()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.FilterInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.io.FilterInputStream(@__env);
			}
		}
		protected FilterInputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12126;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FilterInputStream._close12126);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._close12126);
		}
		internal static global::net.sf.jni4net.jni.MethodId _mark12127;
		public override void mark(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FilterInputStream._mark12127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._mark12127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset12128;
		public override void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FilterInputStream._reset12128);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._reset12128);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12129;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.FilterInputStream._read12129, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read12129, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12130;
		public override int read(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.FilterInputStream._read12130, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read12130, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12131;
		public override int read() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.FilterInputStream._read12131);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read12131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _skip12132;
		public override long skip(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.io.FilterInputStream._skip12132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._skip12132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _available12133;
		public override int available() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.FilterInputStream._available12133);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._available12133);
		}
		internal static global::net.sf.jni4net.jni.MethodId _markSupported12134;
		public override bool markSupported() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.FilterInputStream._markSupported12134);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._markSupported12134);
		}
		internal static global::net.sf.jni4net.jni.MethodId _FilterInputStream12135;
		protected FilterInputStream(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._FilterInputStream12135, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.FilterInputStream.staticClass = @__class;
			global::java.io.FilterInputStream._close12126 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "close", "()V");
			global::java.io.FilterInputStream._mark12127 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "mark", "(I)V");
			global::java.io.FilterInputStream._reset12128 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "reset", "()V");
			global::java.io.FilterInputStream._read12129 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "read", "([BII)I");
			global::java.io.FilterInputStream._read12130 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "read", "([B)I");
			global::java.io.FilterInputStream._read12131 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "read", "()I");
			global::java.io.FilterInputStream._skip12132 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "skip", "(J)J");
			global::java.io.FilterInputStream._available12133 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "available", "()I");
			global::java.io.FilterInputStream._markSupported12134 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "markSupported", "()Z");
			global::java.io.FilterInputStream._FilterInputStream12135 = @__env.GetMethodID(global::java.io.FilterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
