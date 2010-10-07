namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CharBuffer : java.nio.Buffer, java.lang.Comparable, java.lang.Appendable, java.lang.CharSequence, java.lang.Readable
	{
		internal static global::java.lang.Class staticClass;
		static CharBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.CharBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CharBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12725;
		public virtual global::java.nio.CharBuffer get(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._get12725, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get12725, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12726;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._get12726, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get12726, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get12727;
		public abstract char get();
		internal static global::net.sf.jni4net.jni.MethodId _get12728;
		public abstract char get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12729;
		public abstract global::java.nio.CharBuffer put(int arg0, char arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12730;
		public abstract global::java.nio.CharBuffer put(char arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12731;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12732;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12733;
		public virtual global::java.nio.CharBuffer put(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12733, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12733, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12734;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12734, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12734, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12735;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12736;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.CharBuffer._equals12736, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._equals12736, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12737;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._toString12737));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._toString12737));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12738;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._append12738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append12738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12739;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._append12739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append12739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12740;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._append12740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append12740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12741;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._hashCode12741);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hashCode12741);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12742;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._compareTo12742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo12742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12743;
		public virtual int compareTo(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._compareTo12743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo12743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length12744;
		public virtual int length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._length12744);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._length12744);
		}
		internal static global::net.sf.jni4net.jni.MethodId _charAt12745;
		public virtual char charAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.nio.CharBuffer._charAt12745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._charAt12745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subSequence12746;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12747;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12748;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12749;
		public static global::java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12749, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12750;
		public static global::java.nio.CharBuffer wrap(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12750, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12751;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12751, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12752;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._read12752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._read12752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12753;
		public static global::java.nio.CharBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._allocate12753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12754;
		public abstract global::java.nio.CharBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12755;
		public abstract global::java.nio.CharBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12756;
		public abstract global::java.nio.CharBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12757;
		public abstract global::java.nio.CharBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12758;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.CharBuffer.staticClass = @__class;
			global::java.nio.CharBuffer._get12725 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get12726 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get12727 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "()C");
			global::java.nio.CharBuffer._get12728 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer._put12729 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12730 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12731 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12732 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12733 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12734 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12735 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._equals12736 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.CharBuffer._toString12737 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.CharBuffer._append12738 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append12739 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append12740 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._hashCode12741 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "hashCode", "()I");
			global::java.nio.CharBuffer._compareTo12742 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.CharBuffer._compareTo12743 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._length12744 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "length", "()I");
			global::java.nio.CharBuffer._charAt12745 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "charAt", "(I)C");
			global::java.nio.CharBuffer._subSequence12746 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer._isDirect12747 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer._wrap12748 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap12749 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap12750 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap12751 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._read12752 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._allocate12753 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._duplicate12754 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._slice12755 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._asReadOnlyBuffer12756 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._compact12757 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._order12758 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
