namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ShortBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static ShortBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.ShortBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ShortBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12854;
		public abstract short get();
		internal static global::net.sf.jni4net.jni.MethodId _get12855;
		public virtual global::java.nio.ShortBuffer get(short[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._get12855, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get12855, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12856;
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._get12856, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get12856, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12857;
		public abstract short get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12858;
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._put12858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put12858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12859;
		public abstract global::java.nio.ShortBuffer put(short arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12860;
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12861;
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._put12861, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put12861, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12862;
		public virtual global::java.nio.ShortBuffer put(short[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._put12862, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put12862, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12863;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.ShortBuffer._equals12863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._equals12863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12864;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._toString12864));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._toString12864));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12865;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.ShortBuffer._hashCode12865);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hashCode12865);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12866;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.ShortBuffer._compareTo12866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo12866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12867;
		public virtual int compareTo(java.nio.ShortBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.ShortBuffer._compareTo12867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo12867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12868;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12869;
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap12869, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12870;
		public static global::java.nio.ShortBuffer wrap(short[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap12870, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12871;
		public static global::java.nio.ShortBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._allocate12871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12872;
		public abstract global::java.nio.ShortBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12873;
		public abstract global::java.nio.ShortBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12874;
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12875;
		public abstract global::java.nio.ShortBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12876;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.ShortBuffer.staticClass = @__class;
			global::java.nio.ShortBuffer._get12854 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "()S");
			global::java.nio.ShortBuffer._get12855 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get12856 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get12857 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer._put12858 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put12859 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put12860 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put12861 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put12862 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._equals12863 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ShortBuffer._toString12864 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ShortBuffer._hashCode12865 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ShortBuffer._compareTo12866 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ShortBuffer._compareTo12867 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I");
			global::java.nio.ShortBuffer._isDirect12868 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer._wrap12869 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._wrap12870 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._allocate12871 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._duplicate12872 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._slice12873 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._asReadOnlyBuffer12874 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._compact12875 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._order12876 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
