namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CharBuffer : java.nio.Buffer, java.lang.Comparable, java.lang.Appendable, java.lang.CharSequence, java.lang.Readable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CharBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.CharBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CharBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11164; 
		public virtual java.nio.CharBuffer get(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11164, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _get11164, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11165; 
		public virtual java.nio.CharBuffer get(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11165, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _get11165, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11166; 
		public abstract char get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get11167; 
		public abstract char get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11168; 
		public abstract java.nio.CharBuffer put(int arg0, char arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put11169; 
		public abstract java.nio.CharBuffer put(char arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11170; 
		public virtual java.nio.CharBuffer put(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _put11170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11171; 
		public virtual java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _put11171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11172; 
		public virtual java.nio.CharBuffer put(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11172, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _put11172, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11173; 
		public virtual java.nio.CharBuffer put(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11173, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _put11173, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11174; 
		public virtual java.nio.CharBuffer put(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _put11174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11175; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallIntMethod(this, _hashCode11175); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.CharBuffer.staticClass, _hashCode11175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11176; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallBooleanMethod(this, _equals11176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.CharBuffer.staticClass, _equals11176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11177; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11177, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.CharBuffer.staticClass, _compareTo11177, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11178; 
		public virtual int compareTo(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.CharBuffer.staticClass, _compareTo11178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11179; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11179)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _toString11179)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11180; 
		public virtual java.lang.Appendable append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append11180, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _append11180, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11181; 
		public virtual java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append11181, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _append11181, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11182; 
		public virtual java.lang.Appendable append(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append11182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.CharBuffer.staticClass, _append11182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length11183; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallIntMethod(this, _length11183); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.CharBuffer.staticClass, _length11183); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charAt11184; 
		public virtual char charAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallCharMethod(this, _charAt11184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, java.nio.CharBuffer.staticClass, _charAt11184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subSequence11185; 
		public abstract java.lang.CharSequence subSequence(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect11186; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11187; 
		public static java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, _wrap11187, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11188; 
		public static java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, _wrap11188, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11189; 
		public static java.nio.CharBuffer wrap(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, _wrap11189, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11190; 
		public static java.nio.CharBuffer wrap(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, _wrap11190, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read11191; 
		public virtual int read(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.CharBuffer)) 
				return @__env.CallIntMethod(this, _read11191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.CharBuffer.staticClass, _read11191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate11192; 
		public static java.nio.CharBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, _allocate11192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate11193; 
		public abstract java.nio.CharBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice11194; 
		public abstract java.nio.CharBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer11195; 
		public abstract java.nio.CharBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact11196; 
		public abstract java.nio.CharBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order11197; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.CharBuffer.staticClass = @__class; 
			global::java.nio.CharBuffer._get11164 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._get11165 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._get11166 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "()C"); 
			global::java.nio.CharBuffer._get11167 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "(I)C"); 
			global::java.nio.CharBuffer._put11168 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(IC)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._put11169 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(C)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._put11170 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._put11171 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._put11172 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._put11173 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._put11174 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._hashCode11175 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.CharBuffer._equals11176 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.CharBuffer._compareTo11177 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.CharBuffer._compareTo11178 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I"); 
			global::java.nio.CharBuffer._toString11179 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.CharBuffer._append11180 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"); 
			global::java.nio.CharBuffer._append11181 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"); 
			global::java.nio.CharBuffer._append11182 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;"); 
			global::java.nio.CharBuffer._length11183 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "length", "()I"); 
			global::java.nio.CharBuffer._charAt11184 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "charAt", "(I)C"); 
			global::java.nio.CharBuffer._subSequence11185 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;"); 
			global::java.nio.CharBuffer._isDirect11186 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.CharBuffer._wrap11187 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._wrap11188 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._wrap11189 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._wrap11190 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._read11191 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I"); 
			global::java.nio.CharBuffer._allocate11192 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._duplicate11193 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "duplicate", "()Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._slice11194 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "slice", "()Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._asReadOnlyBuffer11195 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._compact11196 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compact", "()Ljava/nio/CharBuffer;"); 
			global::java.nio.CharBuffer._order11197 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
