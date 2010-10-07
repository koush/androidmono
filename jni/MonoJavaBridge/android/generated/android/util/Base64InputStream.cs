namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Base64InputStream : java.io.FilterInputStream
	{
		internal new static global::java.lang.Class staticClass;
		static Base64InputStream()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Base64InputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.Base64InputStream(@__env);
			}
		}
		protected Base64InputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close8168;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.Base64InputStream._close8168);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._close8168);
		}
		internal static global::net.sf.jni4net.jni.MethodId _mark8169;
		public override void mark(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.Base64InputStream._mark8169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._mark8169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset8170;
		public override void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.Base64InputStream._reset8170);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._reset8170);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read8171;
		public override int read() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.Base64InputStream._read8171);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._read8171);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read8172;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.Base64InputStream._read8172, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._read8172, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _skip8173;
		public override long skip(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.util.Base64InputStream._skip8173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._skip8173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _available8174;
		public override int available() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.Base64InputStream._available8174);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._available8174);
		}
		internal static global::net.sf.jni4net.jni.MethodId _markSupported8175;
		public override bool markSupported() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.Base64InputStream._markSupported8175);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._markSupported8175);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Base64InputStream8176;
		public Base64InputStream(java.io.InputStream arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._Base64InputStream8176, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.Base64InputStream.staticClass = @__class;
			global::android.util.Base64InputStream._close8168 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "close", "()V");
			global::android.util.Base64InputStream._mark8169 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "mark", "(I)V");
			global::android.util.Base64InputStream._reset8170 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "reset", "()V");
			global::android.util.Base64InputStream._read8171 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "read", "()I");
			global::android.util.Base64InputStream._read8172 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "read", "([BII)I");
			global::android.util.Base64InputStream._skip8173 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "skip", "(J)J");
			global::android.util.Base64InputStream._available8174 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "available", "()I");
			global::android.util.Base64InputStream._markSupported8175 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "markSupported", "()Z");
			global::android.util.Base64InputStream._Base64InputStream8176 = @__env.GetMethodID(global::android.util.Base64InputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
		}
	}
}
