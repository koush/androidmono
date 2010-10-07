namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class LongBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static LongBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.LongBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected LongBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12828;
		public abstract long get();
		internal static global::net.sf.jni4net.jni.MethodId _get12829;
		public virtual global::java.nio.LongBuffer get(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._get12829, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get12829, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12830;
		public virtual global::java.nio.LongBuffer get(long[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._get12830, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get12830, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12831;
		public abstract long get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12832;
		public virtual global::java.nio.LongBuffer put(java.nio.LongBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._put12832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put12832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12833;
		public abstract global::java.nio.LongBuffer put(long arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12834;
		public abstract global::java.nio.LongBuffer put(int arg0, long arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12835;
		public virtual global::java.nio.LongBuffer put(long[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._put12835, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put12835, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12836;
		public virtual global::java.nio.LongBuffer put(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._put12836, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put12836, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12837;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.LongBuffer._equals12837, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._equals12837, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12838;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._toString12838));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._toString12838));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12839;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.LongBuffer._hashCode12839);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hashCode12839);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12840;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.LongBuffer._compareTo12840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo12840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12841;
		public virtual int compareTo(java.nio.LongBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.LongBuffer._compareTo12841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo12841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12842;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12843;
		public static global::java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap12843, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12844;
		public static global::java.nio.LongBuffer wrap(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap12844, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12845;
		public static global::java.nio.LongBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._allocate12845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12846;
		public abstract global::java.nio.LongBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12847;
		public abstract global::java.nio.LongBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12848;
		public abstract global::java.nio.LongBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12849;
		public abstract global::java.nio.LongBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12850;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.LongBuffer.staticClass = @__class;
			global::java.nio.LongBuffer._get12828 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "()J");
			global::java.nio.LongBuffer._get12829 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get12830 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get12831 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer._put12832 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12833 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12834 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12835 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12836 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._equals12837 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.LongBuffer._toString12838 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.LongBuffer._hashCode12839 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "hashCode", "()I");
			global::java.nio.LongBuffer._compareTo12840 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.LongBuffer._compareTo12841 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I");
			global::java.nio.LongBuffer._isDirect12842 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer._wrap12843 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._wrap12844 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._allocate12845 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._duplicate12846 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._slice12847 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._asReadOnlyBuffer12848 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._compact12849 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._order12850 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
