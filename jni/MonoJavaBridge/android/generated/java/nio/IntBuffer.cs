namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static IntBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.IntBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected IntBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12805;
		public abstract int get();
		internal static global::net.sf.jni4net.jni.MethodId _get12806;
		public virtual global::java.nio.IntBuffer get(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._get12806, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get12806, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12807;
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._get12807, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get12807, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12808;
		public abstract int get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12809;
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._put12809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put12809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12810;
		public abstract global::java.nio.IntBuffer put(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12811;
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12812;
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._put12812, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put12812, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12813;
		public virtual global::java.nio.IntBuffer put(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._put12813, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put12813, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12814;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.IntBuffer._equals12814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._equals12814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12815;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._toString12815));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._toString12815));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12816;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.IntBuffer._hashCode12816);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hashCode12816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12817;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.IntBuffer._compareTo12817, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo12817, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12818;
		public virtual int compareTo(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.IntBuffer._compareTo12818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo12818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12819;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12820;
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap12820, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12821;
		public static global::java.nio.IntBuffer wrap(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap12821, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12822;
		public static global::java.nio.IntBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._allocate12822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12823;
		public abstract global::java.nio.IntBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12824;
		public abstract global::java.nio.IntBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12825;
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12826;
		public abstract global::java.nio.IntBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12827;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.IntBuffer.staticClass = @__class;
			global::java.nio.IntBuffer._get12805 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "()I");
			global::java.nio.IntBuffer._get12806 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get12807 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get12808 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer._put12809 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put12810 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put12811 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put12812 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put12813 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._equals12814 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.IntBuffer._toString12815 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.IntBuffer._hashCode12816 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "hashCode", "()I");
			global::java.nio.IntBuffer._compareTo12817 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.IntBuffer._compareTo12818 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I");
			global::java.nio.IntBuffer._isDirect12819 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer._wrap12820 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._wrap12821 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._allocate12822 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._duplicate12823 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._slice12824 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._asReadOnlyBuffer12825 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._compact12826 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._order12827 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
