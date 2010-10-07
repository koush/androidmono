namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class FloatBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static FloatBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.FloatBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected FloatBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12782;
		public abstract float get();
		internal static global::net.sf.jni4net.jni.MethodId _get12783;
		public virtual global::java.nio.FloatBuffer get(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._get12783, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get12783, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12784;
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._get12784, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get12784, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12785;
		public abstract float get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12786;
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._put12786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put12786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12787;
		public abstract global::java.nio.FloatBuffer put(float arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12788;
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12789;
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._put12789, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put12789, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12790;
		public virtual global::java.nio.FloatBuffer put(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._put12790, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put12790, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12791;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.FloatBuffer._equals12791, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._equals12791, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12792;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._toString12792));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._toString12792));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12793;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.FloatBuffer._hashCode12793);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hashCode12793);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12794;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.FloatBuffer._compareTo12794, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo12794, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12795;
		public virtual int compareTo(java.nio.FloatBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.FloatBuffer._compareTo12795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo12795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12796;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12797;
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap12797, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12798;
		public static global::java.nio.FloatBuffer wrap(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap12798, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12799;
		public static global::java.nio.FloatBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._allocate12799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12800;
		public abstract global::java.nio.FloatBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12801;
		public abstract global::java.nio.FloatBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12802;
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12803;
		public abstract global::java.nio.FloatBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12804;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.FloatBuffer.staticClass = @__class;
			global::java.nio.FloatBuffer._get12782 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "()F");
			global::java.nio.FloatBuffer._get12783 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get12784 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get12785 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer._put12786 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put12787 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put12788 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put12789 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put12790 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._equals12791 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.FloatBuffer._toString12792 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.FloatBuffer._hashCode12793 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I");
			global::java.nio.FloatBuffer._compareTo12794 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.FloatBuffer._compareTo12795 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I");
			global::java.nio.FloatBuffer._isDirect12796 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer._wrap12797 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._wrap12798 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._allocate12799 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._duplicate12800 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._slice12801 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._asReadOnlyBuffer12802 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._compact12803 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._order12804 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
