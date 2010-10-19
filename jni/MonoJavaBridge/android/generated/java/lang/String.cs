namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class String : java.lang.Object, java.io.Serializable, Comparable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static String()
		{
			InitJNI();
		}
		internal String(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals14960;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._equals14960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._equals14960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14961;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toString14961)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toString14961)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14962;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._hashCode14962);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._hashCode14962);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14963;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._compareTo14963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._compareTo14963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14964;
		public int compareTo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._compareTo14964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._compareTo14964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf14965;
		public int indexOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf14965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf14965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf14966;
		public int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf14966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf14966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf14967;
		public int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf14967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf14967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf14968;
		public int indexOf(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf14968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf14968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length14969;
		public int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._length14969);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._length14969);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty14970;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._isEmpty14970);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._isEmpty14970);
		}
		internal static global::MonoJavaBridge.MethodId _charAt14971;
		public char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.String._charAt14971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._charAt14971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt14972;
		public int codePointAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._codePointAt14972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._codePointAt14972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore14973;
		public int codePointBefore(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._codePointBefore14973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._codePointBefore14973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount14974;
		public int codePointCount(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._codePointCount14974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._codePointCount14974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints14975;
		public int offsetByCodePoints(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._offsetByCodePoints14975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._offsetByCodePoints14975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars14976;
		public void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.String._getChars14976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getChars14976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes14977;
		public void getBytes(int arg0, int arg1, byte[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.String._getBytes14977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes14977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes14978;
		public byte[] getBytes(java.nio.charset.Charset arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._getBytes14978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes14978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		public new byte[] Bytes
		{
			get
			{
				return getBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytes14979;
		public byte[] getBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._getBytes14979)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes14979)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes14980;
		public byte[] getBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._getBytes14980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes14980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _contentEquals14981;
		public bool contentEquals(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._contentEquals14981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._contentEquals14981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contentEquals14982;
		public bool contentEquals(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._contentEquals14982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._contentEquals14982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool contentEquals(string arg0)
		{
			return contentEquals((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _equalsIgnoreCase14983;
		public bool equalsIgnoreCase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._equalsIgnoreCase14983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._equalsIgnoreCase14983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareToIgnoreCase14984;
		public int compareToIgnoreCase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._compareToIgnoreCase14984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._compareToIgnoreCase14984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches14985;
		public bool regionMatches(bool arg0, int arg1, java.lang.String arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._regionMatches14985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._regionMatches14985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches14986;
		public bool regionMatches(int arg0, java.lang.String arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._regionMatches14986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._regionMatches14986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startsWith14987;
		public bool startsWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._startsWith14987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._startsWith14987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startsWith14988;
		public bool startsWith(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._startsWith14988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._startsWith14988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endsWith14989;
		public bool endsWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._endsWith14989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._endsWith14989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf14990;
		public int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf14990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf14990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf14991;
		public int lastIndexOf(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf14991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf14991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf14992;
		public int lastIndexOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf14992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf14992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf14993;
		public int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf14993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf14993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring14994;
		public global::java.lang.String substring(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._substring14994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._substring14994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring14995;
		public global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._substring14995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._substring14995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence14996;
		public global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._subSequence14996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._subSequence14996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _concat14997;
		public global::java.lang.String concat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._concat14997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._concat14997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replace14998;
		public global::java.lang.String replace(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replace14998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replace14998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replace14999;
		public global::java.lang.String replace(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replace14999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replace14999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public java.lang.String replace(string arg0, string arg1)
		{
			return replace((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _matches15000;
		public bool matches(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._matches15000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._matches15000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains15001;
		public bool contains(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._contains15001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._contains15001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool contains(string arg0)
		{
			return contains((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _replaceFirst15002;
		public global::java.lang.String replaceFirst(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replaceFirst15002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replaceFirst15002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll15003;
		public global::java.lang.String replaceAll(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replaceAll15003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replaceAll15003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _split15004;
		public global::java.lang.String[] split(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._split15004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._split15004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _split15005;
		public global::java.lang.String[] split(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._split15005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._split15005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase15006;
		public global::java.lang.String toLowerCase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toLowerCase15006)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toLowerCase15006)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase15007;
		public global::java.lang.String toLowerCase(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toLowerCase15007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toLowerCase15007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase15008;
		public global::java.lang.String toUpperCase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toUpperCase15008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toUpperCase15008)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase15009;
		public global::java.lang.String toUpperCase(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toUpperCase15009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toUpperCase15009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _trim15010;
		public global::java.lang.String trim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._trim15010)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._trim15010)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray15011;
		public char[] toCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toCharArray15011)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toCharArray15011)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _format15012;
		public static global::java.lang.String format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._format15012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format15013;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._format15013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15014;
		public static global::java.lang.String valueOf(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15015;
		public static global::java.lang.String valueOf(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15016;
		public static global::java.lang.String valueOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15017;
		public static global::java.lang.String valueOf(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15018;
		public static global::java.lang.String valueOf(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15019;
		public static global::java.lang.String valueOf(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15020;
		public static global::java.lang.String valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15021;
		public static global::java.lang.String valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15022;
		public static global::java.lang.String valueOf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf15022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _copyValueOf15023;
		public static global::java.lang.String copyValueOf(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._copyValueOf15023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _copyValueOf15024;
		public static global::java.lang.String copyValueOf(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._copyValueOf15024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _intern15025;
		public global::java.lang.String intern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._intern15025)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._intern15025)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _String15026;
		public String()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15026);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15027;
		public String(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15028;
		public String(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15029;
		public String(char[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15030;
		public String(int[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15031;
		public String(byte[] arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15032;
		public String(byte[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15033;
		public String(byte[] arg0, java.nio.charset.Charset arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15034;
		public String(byte[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15035;
		public String(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15036;
		public String(java.lang.StringBuffer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15037;
		public String(java.lang.StringBuilder arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15038;
		public String(byte[] arg0, int arg1, int arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15039;
		public String(byte[] arg0, int arg1, int arg2, java.nio.charset.Charset arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String15040;
		public String(byte[] arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String15040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CASE_INSENSITIVE_ORDER15041;
		public static global::java.util.Comparator CASE_INSENSITIVE_ORDER
		{
			get
			{
				return default(global::java.util.Comparator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.String.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/String"));
			global::java.lang.String._equals14960 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.String._toString14961 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.String._hashCode14962 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "hashCode", "()I");
			global::java.lang.String._compareTo14963 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.String._compareTo14964 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "compareTo", "(Ljava/lang/String;)I");
			global::java.lang.String._indexOf14965 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(I)I");
			global::java.lang.String._indexOf14966 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.String._indexOf14967 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.String._indexOf14968 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(II)I");
			global::java.lang.String._length14969 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "length", "()I");
			global::java.lang.String._isEmpty14970 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "isEmpty", "()Z");
			global::java.lang.String._charAt14971 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "charAt", "(I)C");
			global::java.lang.String._codePointAt14972 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "codePointAt", "(I)I");
			global::java.lang.String._codePointBefore14973 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "codePointBefore", "(I)I");
			global::java.lang.String._codePointCount14974 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "codePointCount", "(II)I");
			global::java.lang.String._offsetByCodePoints14975 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.String._getChars14976 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getChars", "(II[CI)V");
			global::java.lang.String._getBytes14977 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "(II[BI)V");
			global::java.lang.String._getBytes14978 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "(Ljava/nio/charset/Charset;)[B");
			global::java.lang.String._getBytes14979 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "()[B");
			global::java.lang.String._getBytes14980 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.lang.String._contentEquals14981 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "contentEquals", "(Ljava/lang/StringBuffer;)Z");
			global::java.lang.String._contentEquals14982 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "contentEquals", "(Ljava/lang/CharSequence;)Z");
			global::java.lang.String._equalsIgnoreCase14983 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "equalsIgnoreCase", "(Ljava/lang/String;)Z");
			global::java.lang.String._compareToIgnoreCase14984 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "compareToIgnoreCase", "(Ljava/lang/String;)I");
			global::java.lang.String._regionMatches14985 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "regionMatches", "(ZILjava/lang/String;II)Z");
			global::java.lang.String._regionMatches14986 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "regionMatches", "(ILjava/lang/String;II)Z");
			global::java.lang.String._startsWith14987 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "startsWith", "(Ljava/lang/String;)Z");
			global::java.lang.String._startsWith14988 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "startsWith", "(Ljava/lang/String;I)Z");
			global::java.lang.String._endsWith14989 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "endsWith", "(Ljava/lang/String;)Z");
			global::java.lang.String._lastIndexOf14990 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.String._lastIndexOf14991 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(II)I");
			global::java.lang.String._lastIndexOf14992 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(I)I");
			global::java.lang.String._lastIndexOf14993 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.String._substring14994 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.String._substring14995 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.String._subSequence14996 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.String._concat14997 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "concat", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.String._replace14998 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replace", "(CC)Ljava/lang/String;");
			global::java.lang.String._replace14999 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;");
			global::java.lang.String._matches15000 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "matches", "(Ljava/lang/String;)Z");
			global::java.lang.String._contains15001 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "contains", "(Ljava/lang/CharSequence;)Z");
			global::java.lang.String._replaceFirst15002 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.String._replaceAll15003 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.String._split15004 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "split", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::java.lang.String._split15005 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "split", "(Ljava/lang/String;I)[Ljava/lang/String;");
			global::java.lang.String._toLowerCase15006 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toLowerCase", "()Ljava/lang/String;");
			global::java.lang.String._toLowerCase15007 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.lang.String._toUpperCase15008 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toUpperCase", "()Ljava/lang/String;");
			global::java.lang.String._toUpperCase15009 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.lang.String._trim15010 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "trim", "()Ljava/lang/String;");
			global::java.lang.String._toCharArray15011 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toCharArray", "()[C");
			global::java.lang.String._format15012 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			global::java.lang.String._format15013 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			global::java.lang.String._valueOf15014 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "([C)Ljava/lang/String;");
			global::java.lang.String._valueOf15015 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(D)Ljava/lang/String;");
			global::java.lang.String._valueOf15016 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;");
			global::java.lang.String._valueOf15017 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "([CII)Ljava/lang/String;");
			global::java.lang.String._valueOf15018 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(Z)Ljava/lang/String;");
			global::java.lang.String._valueOf15019 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(C)Ljava/lang/String;");
			global::java.lang.String._valueOf15020 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(I)Ljava/lang/String;");
			global::java.lang.String._valueOf15021 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(J)Ljava/lang/String;");
			global::java.lang.String._valueOf15022 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(F)Ljava/lang/String;");
			global::java.lang.String._copyValueOf15023 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "copyValueOf", "([CII)Ljava/lang/String;");
			global::java.lang.String._copyValueOf15024 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "copyValueOf", "([C)Ljava/lang/String;");
			global::java.lang.String._intern15025 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "intern", "()Ljava/lang/String;");
			global::java.lang.String._String15026 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "()V");
			global::java.lang.String._String15027 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.String._String15028 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([C)V");
			global::java.lang.String._String15029 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([CII)V");
			global::java.lang.String._String15030 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([III)V");
			global::java.lang.String._String15031 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIII)V");
			global::java.lang.String._String15032 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BI)V");
			global::java.lang.String._String15033 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BLjava/nio/charset/Charset;)V");
			global::java.lang.String._String15034 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BII)V");
			global::java.lang.String._String15035 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([B)V");
			global::java.lang.String._String15036 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/StringBuffer;)V");
			global::java.lang.String._String15037 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V");
			global::java.lang.String._String15038 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIILjava/lang/String;)V");
			global::java.lang.String._String15039 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIILjava/nio/charset/Charset;)V");
			global::java.lang.String._String15040 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BLjava/lang/String;)V");
		}
	}
}
