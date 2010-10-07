namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface GetChars : java.lang.CharSequence
	{
		void getChars(int arg0, int arg1, char[] arg2, int arg3);
	}

	public partial class GetChars_
	{
		public static global::java.lang.Class _class
		{
			get { return __GetChars.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __GetChars : java.lang.Object, GetChars
	{
		internal static global::java.lang.Class staticClass;
		static __GetChars()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__GetChars), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.__GetChars(@__env);
			}
		}
		internal __GetChars(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChars7401;
		 void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__GetChars._getChars7401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__GetChars.staticClass, global::android.text.__GetChars._getChars7401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7402;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__GetChars._toString7402));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__GetChars.staticClass, global::android.text.__GetChars._toString7402));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length7403;
		 int java.lang.CharSequence.length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__GetChars._length7403);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__GetChars.staticClass, global::android.text.__GetChars._length7403);
		}
		internal static global::net.sf.jni4net.jni.MethodId _charAt7404;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.text.__GetChars._charAt7404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.text.__GetChars.staticClass, global::android.text.__GetChars._charAt7404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subSequence7405;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__GetChars._subSequence7405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__GetChars.staticClass, global::android.text.__GetChars._subSequence7405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.__GetChars.staticClass = @__class;
			global::android.text.__GetChars._getChars7401 = @__env.GetMethodID(global::android.text.__GetChars.staticClass, "android.text.GetChars.getChars", "(II[CI)V");
			global::android.text.__GetChars._toString7402 = @__env.GetMethodID(global::android.text.__GetChars.staticClass, "java.lang.CharSequence.toString", "()Ljava/lang/String;");
			global::android.text.__GetChars._length7403 = @__env.GetMethodID(global::android.text.__GetChars.staticClass, "java.lang.CharSequence.length", "()I");
			global::android.text.__GetChars._charAt7404 = @__env.GetMethodID(global::android.text.__GetChars.staticClass, "java.lang.CharSequence.charAt", "(I)C");
			global::android.text.__GetChars._subSequence7405 = @__env.GetMethodID(global::android.text.__GetChars.staticClass, "java.lang.CharSequence.subSequence", "(II)Ljava/lang/CharSequence;");
		}
	}
}
