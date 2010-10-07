namespace java.lang
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Enum : java.lang.Object, Comparable, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Enum()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.Enum), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Enum(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _name12208;
		public virtual global::java.lang.String name() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Enum._name12208));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._name12208));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12209;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Enum._equals12209, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._equals12209, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12210;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Enum._toString12210));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._toString12210));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12211;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Enum._hashCode12211);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._hashCode12211);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12212;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Enum._compareTo12212, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo12212, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12213;
		public virtual int compareTo(java.lang.Enum arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Enum._compareTo12213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo12213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf12214;
		public static global::java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Enum>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Enum.staticClass, global::java.lang.Enum._valueOf12214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass12215;
		public virtual global::java.lang.Class getDeclaringClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Enum._getDeclaringClass12215));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._getDeclaringClass12215));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ordinal12216;
		public virtual int ordinal() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Enum._ordinal12216);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Enum.staticClass, global::java.lang.Enum._ordinal12216);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Enum12217;
		protected Enum(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Enum.staticClass, global::java.lang.Enum._Enum12217, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.lang.Enum.staticClass = @__class;
			global::java.lang.Enum._name12208 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;");
			global::java.lang.Enum._equals12209 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Enum._toString12210 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Enum._hashCode12211 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "hashCode", "()I");
			global::java.lang.Enum._compareTo12212 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Enum._compareTo12213 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I");
			global::java.lang.Enum._valueOf12214 = @__env.GetStaticMethodID(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			global::java.lang.Enum._getDeclaringClass12215 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Enum._ordinal12216 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "ordinal", "()I");
			global::java.lang.Enum._Enum12217 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
