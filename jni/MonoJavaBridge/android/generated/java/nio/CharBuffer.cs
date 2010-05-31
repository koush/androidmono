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
		internal static global::net.sf.jni4net.jni.MethodId _get11996;
		public virtual global::java.nio.CharBuffer get(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._get11996, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get11996, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get11997;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._get11997, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get11997, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get11998;
		public abstract char get();
		internal static global::net.sf.jni4net.jni.MethodId _get11999;
		public abstract char get(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12000;
		public abstract global::java.nio.CharBuffer put(int arg0, char arg1);
		internal static global::net.sf.jni4net.jni.MethodId _put12001;
		public abstract global::java.nio.CharBuffer put(char arg0);
		internal static global::net.sf.jni4net.jni.MethodId _put12002;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12003;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12004;
		public virtual global::java.nio.CharBuffer put(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12004, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12004, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12005;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12005, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12005, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put12006;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._put12006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put12006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12007;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._hashCode12007);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hashCode12007);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12008;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.CharBuffer._equals12008, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._equals12008, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12009;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._compareTo12009, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo12009, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12010;
		public virtual int compareTo(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._compareTo12010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo12010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12011;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._toString12011));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._toString12011));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12012;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._append12012, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append12012, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12013;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._append12013, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append12013, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12014;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.CharBuffer._append12014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append12014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length12015;
		public virtual int length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._length12015);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._length12015);
		}
		internal static global::net.sf.jni4net.jni.MethodId _charAt12016;
		public virtual char charAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.nio.CharBuffer._charAt12016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._charAt12016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subSequence12017;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12018;
		public abstract bool isDirect();
		internal static global::net.sf.jni4net.jni.MethodId _wrap12019;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12019, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12020;
		public static global::java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12020, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12021;
		public static global::java.nio.CharBuffer wrap(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12021, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap12022;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap12022, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12023;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.CharBuffer._read12023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._read12023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocate12024;
		public static global::java.nio.CharBuffer allocate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._allocate12024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12025;
		public abstract global::java.nio.CharBuffer duplicate();
		internal static global::net.sf.jni4net.jni.MethodId _slice12026;
		public abstract global::java.nio.CharBuffer slice();
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12027;
		public abstract global::java.nio.CharBuffer asReadOnlyBuffer();
		internal static global::net.sf.jni4net.jni.MethodId _compact12028;
		public abstract global::java.nio.CharBuffer compact();
		internal static global::net.sf.jni4net.jni.MethodId _order12029;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.CharBuffer.staticClass = @__class;
			global::java.nio.CharBuffer._get11996 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get11997 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get11998 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "()C");
			global::java.nio.CharBuffer._get11999 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer._put12000 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12001 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12002 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12003 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12004 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12005 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put12006 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._hashCode12007 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "hashCode", "()I");
			global::java.nio.CharBuffer._equals12008 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.CharBuffer._compareTo12009 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.CharBuffer._compareTo12010 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._toString12011 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.CharBuffer._append12012 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append12013 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append12014 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._length12015 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "length", "()I");
			global::java.nio.CharBuffer._charAt12016 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "charAt", "(I)C");
			global::java.nio.CharBuffer._subSequence12017 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer._isDirect12018 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer._wrap12019 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap12020 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap12021 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap12022 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._read12023 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._allocate12024 = @__env.GetStaticMethodID(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._duplicate12025 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._slice12026 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._asReadOnlyBuffer12027 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._compact12028 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._order12029 = @__env.GetMethodID(global::java.nio.CharBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}
}
