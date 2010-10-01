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
		internal static global::net.sf.jni4net.jni.MethodId _get12099;
		public abstract long get();
		internal static global::net.sf.jni4net.jni.MethodId _get12100;
		public virtual global::java.nio.LongBuffer get(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._get12100, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get12100, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12101;
		public virtual global::java.nio.LongBuffer get(long[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._get12101, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get12101, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12102;
		public abstract long get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12103;
		public virtual global::java.nio.LongBuffer put(java.nio.LongBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._put12103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put12103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12104;
		public abstract global::java.nio.LongBuffer put(long arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12105;
		public abstract global::java.nio.LongBuffer put(int arg0, long arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12106;
		public virtual global::java.nio.LongBuffer put(long[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._put12106, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put12106, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12107;
		public virtual global::java.nio.LongBuffer put(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._put12107, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put12107, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12108;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.LongBuffer._equals12108, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._equals12108, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12109;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.LongBuffer._toString12109));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._toString12109));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12110;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.LongBuffer._hashCode12110);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hashCode12110);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12111;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.LongBuffer._compareTo12111, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo12111, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12112;
		public virtual int compareTo(java.nio.LongBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.LongBuffer._compareTo12112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo12112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12113;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12114;
		public static global::java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap12114, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12115;
		public static global::java.nio.LongBuffer wrap(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap12115, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12116;
		public static global::java.nio.LongBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._allocate12116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12117;
		public abstract global::java.nio.LongBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12118;
		public abstract global::java.nio.LongBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12119;
		public abstract global::java.nio.LongBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12120;
		public abstract global::java.nio.LongBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12121;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.LongBuffer.staticClass = @__class;
			global::java.nio.LongBuffer._get12099 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "()J");
			global::java.nio.LongBuffer._get12100 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get12101 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get12102 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer._put12103 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12104 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12105 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12106 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put12107 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._equals12108 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.LongBuffer._toString12109 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.LongBuffer._hashCode12110 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "hashCode", "()I");
			global::java.nio.LongBuffer._compareTo12111 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.LongBuffer._compareTo12112 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I");
			global::java.nio.LongBuffer._isDirect12113 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer._wrap12114 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._wrap12115 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._allocate12116 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._duplicate12117 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._slice12118 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._asReadOnlyBuffer12119 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._compact12120 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._order12121 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
