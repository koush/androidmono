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
		internal static global::net.sf.jni4net.jni.MethodId _get12125; 
		public abstract short get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get12126; 
		public virtual global::java.nio.ShortBuffer get(short[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._get12126, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get12126, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12127; 
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._get12127, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get12127, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12128; 
		public abstract short get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12129; 
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._put12129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put12129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12130; 
		public abstract global::java.nio.ShortBuffer put(short arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12131; 
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put12132; 
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._put12132, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put12132, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12133; 
		public virtual global::java.nio.ShortBuffer put(short[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._put12133, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put12133, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12134; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.ShortBuffer._hashCode12134); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hashCode12134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12135; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.nio.ShortBuffer._equals12135, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._equals12135, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12136; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.ShortBuffer._compareTo12136, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo12136, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12137; 
		public virtual int compareTo(java.nio.ShortBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.ShortBuffer._compareTo12137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo12137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12138; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ShortBuffer._toString12138)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._toString12138)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12139; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12140; 
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap12140, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12141; 
		public static global::java.nio.ShortBuffer wrap(short[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap12141, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate12142; 
		public static global::java.nio.ShortBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._allocate12142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12143; 
		public abstract global::java.nio.ShortBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice12144; 
		public abstract global::java.nio.ShortBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12145; 
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact12146; 
		public abstract global::java.nio.ShortBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order12147; 
		public abstract global::java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.ShortBuffer.staticClass = @__class; 
			global::java.nio.ShortBuffer._get12125 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "()S"); 
			global::java.nio.ShortBuffer._get12126 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._get12127 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._get12128 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "(I)S"); 
			global::java.nio.ShortBuffer._put12129 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put12130 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put12131 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put12132 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put12133 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._hashCode12134 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.ShortBuffer._equals12135 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.ShortBuffer._compareTo12136 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.ShortBuffer._compareTo12137 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I"); 
			global::java.nio.ShortBuffer._toString12138 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.ShortBuffer._isDirect12139 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.ShortBuffer._wrap12140 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._wrap12141 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._allocate12142 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._duplicate12143 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._slice12144 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "slice", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._asReadOnlyBuffer12145 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._compact12146 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compact", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._order12147 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
