namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class DoubleBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static DoubleBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.DoubleBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected DoubleBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12759;
		public abstract double get();
		internal static global::net.sf.jni4net.jni.MethodId _get12760;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.DoubleBuffer._get12760, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get12760, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12761;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.DoubleBuffer._get12761, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get12761, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12762;
		public abstract double get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12763;
		public virtual global::java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.DoubleBuffer._put12763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put12763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12764;
		public abstract global::java.nio.DoubleBuffer put(double arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12765;
		public abstract global::java.nio.DoubleBuffer put(int arg0, double arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12766;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.DoubleBuffer._put12766, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put12766, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12767;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.DoubleBuffer._put12767, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put12767, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12768;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.DoubleBuffer._equals12768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._equals12768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12769;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.DoubleBuffer._toString12769));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._toString12769));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12770;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.DoubleBuffer._hashCode12770);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hashCode12770);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12771;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.DoubleBuffer._compareTo12771, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo12771, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12772;
		public virtual int compareTo(java.nio.DoubleBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.DoubleBuffer._compareTo12772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo12772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12773;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12774;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap12774, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12775;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap12775, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12776;
		public static global::java.nio.DoubleBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._allocate12776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12777;
		public abstract global::java.nio.DoubleBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12778;
		public abstract global::java.nio.DoubleBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12779;
		public abstract global::java.nio.DoubleBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12780;
		public abstract global::java.nio.DoubleBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12781;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.DoubleBuffer.staticClass = @__class;
			global::java.nio.DoubleBuffer._get12759 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer._get12760 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get12761 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get12762 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer._put12763 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put12764 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put12765 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put12766 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put12767 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._equals12768 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.DoubleBuffer._toString12769 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.DoubleBuffer._hashCode12770 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I");
			global::java.nio.DoubleBuffer._compareTo12771 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.DoubleBuffer._compareTo12772 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I");
			global::java.nio.DoubleBuffer._isDirect12773 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer._wrap12774 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._wrap12775 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._allocate12776 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._duplicate12777 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._slice12778 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._asReadOnlyBuffer12779 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._compact12780 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._order12781 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
