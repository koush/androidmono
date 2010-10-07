namespace android.text.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Rfc822Token : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Rfc822Token()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.util.Rfc822Token), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.util.Rfc822Token(@__env);
			}
		}
		protected Rfc822Token(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals8114;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.util.Rfc822Token._equals8114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._equals8114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString8115;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.util.Rfc822Token._toString8115));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._toString8115));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode8116;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.util.Rfc822Token._hashCode8116);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._hashCode8116);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAddress8117;
		public virtual global::java.lang.String getAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.util.Rfc822Token._getAddress8117));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getAddress8117));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName8118;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.util.Rfc822Token._getName8118));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getName8118));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setName8119;
		public virtual void setName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.util.Rfc822Token._setName8119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setName8119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setComment8120;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.util.Rfc822Token._setComment8120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setComment8120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComment8121;
		public virtual global::java.lang.String getComment() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.util.Rfc822Token._getComment8121));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getComment8121));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAddress8122;
		public virtual void setAddress(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.util.Rfc822Token._setAddress8122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setAddress8122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quoteNameIfNecessary8123;
		public static global::java.lang.String quoteNameIfNecessary(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteNameIfNecessary8123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quoteName8124;
		public static global::java.lang.String quoteName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteName8124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quoteComment8125;
		public static global::java.lang.String quoteComment(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteComment8125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Rfc822Token8126;
		public Rfc822Token(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._Rfc822Token8126, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.util.Rfc822Token.staticClass = @__class;
			global::android.text.util.Rfc822Token._equals8114 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.text.util.Rfc822Token._toString8115 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._hashCode8116 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "hashCode", "()I");
			global::android.text.util.Rfc822Token._getAddress8117 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._getName8118 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "getName", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setName8119 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._setComment8120 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._getComment8121 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "getComment", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setAddress8122 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "setAddress", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._quoteNameIfNecessary8123 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Token.staticClass, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteName8124 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Token.staticClass, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteComment8125 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Token.staticClass, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._Rfc822Token8126 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
