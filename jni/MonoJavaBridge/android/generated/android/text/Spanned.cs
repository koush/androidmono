namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Spanned : java.lang.CharSequence
	{
		global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2);
		int getSpanStart(java.lang.Object arg0);
		int getSpanEnd(java.lang.Object arg0);
		int getSpanFlags(java.lang.Object arg0);
		int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2);
	}

	public partial class Spanned_
	{
		public static global::java.lang.Class _class
		{
			get { return __Spanned.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Spanned : java.lang.Object, Spanned
	{
		internal static global::java.lang.Class staticClass;
		static __Spanned()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__Spanned), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.__Spanned(@__env);
			}
		}
		internal __Spanned(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpans6944;
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Spanned._getSpans6944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._getSpans6944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanStart6945;
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Spanned._getSpanStart6945, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._getSpanStart6945, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanEnd6946;
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Spanned._getSpanEnd6946, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._getSpanEnd6946, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanFlags6947;
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Spanned._getSpanFlags6947, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._getSpanFlags6947, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextSpanTransition6948;
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Spanned._nextSpanTransition6948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._nextSpanTransition6948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6949;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Spanned._toString6949));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._toString6949));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length6950;
		 int java.lang.CharSequence.length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Spanned._length6950);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._length6950);
		}
		internal static global::net.sf.jni4net.jni.MethodId _charAt6951;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.text.__Spanned._charAt6951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._charAt6951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6952;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Spanned._subSequence6952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Spanned.staticClass, global::android.text.__Spanned._subSequence6952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.__Spanned.staticClass = @__class;
			global::android.text.__Spanned._getSpans6944 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "android.text.Spanned.getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.__Spanned._getSpanStart6945 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "android.text.Spanned.getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.__Spanned._getSpanEnd6946 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "android.text.Spanned.getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.__Spanned._getSpanFlags6947 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "android.text.Spanned.getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.__Spanned._nextSpanTransition6948 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "android.text.Spanned.nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.__Spanned._toString6949 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "java.lang.CharSequence.toString", "()Ljava/lang/String;");
			global::android.text.__Spanned._length6950 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "java.lang.CharSequence.length", "()I");
			global::android.text.__Spanned._charAt6951 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "java.lang.CharSequence.charAt", "(I)C");
			global::android.text.__Spanned._subSequence6952 = @__env.GetMethodID(global::android.text.__Spanned.staticClass, "java.lang.CharSequence.subSequence", "(II)Ljava/lang/CharSequence;");
		}
	}
}
