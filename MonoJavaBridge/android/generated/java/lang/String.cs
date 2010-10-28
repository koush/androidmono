namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class String : java.lang.Object, java.io.Serializable, Comparable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal String(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20598;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._equals20598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._equals20598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20599;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toString20599)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toString20599)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20600;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._hashCode20600);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._hashCode20600);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20601;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._compareTo20601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._compareTo20601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20602;
		public int compareTo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._compareTo20602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._compareTo20602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20603;
		public int indexOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf20603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf20603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20604;
		public int indexOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf20604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf20604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20605;
		public int indexOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf20605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf20605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20606;
		public int indexOf(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._indexOf20606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._indexOf20606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length20607;
		public int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._length20607);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._length20607);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20608;
		public bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._isEmpty20608);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._isEmpty20608);
		}
		internal static global::MonoJavaBridge.MethodId _charAt20609;
		public char charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.String._charAt20609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._charAt20609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt20610;
		public int codePointAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._codePointAt20610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._codePointAt20610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore20611;
		public int codePointBefore(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._codePointBefore20611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._codePointBefore20611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount20612;
		public int codePointCount(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._codePointCount20612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._codePointCount20612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints20613;
		public int offsetByCodePoints(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._offsetByCodePoints20613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._offsetByCodePoints20613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars20614;
		public void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.String._getChars20614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getChars20614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes20615;
		public void getBytes(int arg0, int arg1, byte[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.String._getBytes20615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes20615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes20616;
		public byte[] getBytes(java.nio.charset.Charset arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._getBytes20616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes20616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		public new byte[] Bytes
		{
			get
			{
				return getBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytes20617;
		public byte[] getBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._getBytes20617)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes20617)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes20618;
		public byte[] getBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._getBytes20618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._getBytes20618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _contentEquals20619;
		public bool contentEquals(java.lang.StringBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._contentEquals20619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._contentEquals20619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contentEquals20620;
		public bool contentEquals(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._contentEquals20620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._contentEquals20620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool contentEquals(string arg0)
		{
			return contentEquals((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _equalsIgnoreCase20621;
		public bool equalsIgnoreCase(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._equalsIgnoreCase20621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._equalsIgnoreCase20621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareToIgnoreCase20622;
		public int compareToIgnoreCase(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._compareToIgnoreCase20622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._compareToIgnoreCase20622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches20623;
		public bool regionMatches(bool arg0, int arg1, java.lang.String arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._regionMatches20623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._regionMatches20623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches20624;
		public bool regionMatches(int arg0, java.lang.String arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._regionMatches20624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._regionMatches20624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startsWith20625;
		public bool startsWith(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._startsWith20625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._startsWith20625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startsWith20626;
		public bool startsWith(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._startsWith20626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._startsWith20626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endsWith20627;
		public bool endsWith(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._endsWith20627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._endsWith20627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20628;
		public int lastIndexOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf20628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf20628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20629;
		public int lastIndexOf(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf20629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf20629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20630;
		public int lastIndexOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf20630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf20630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20631;
		public int lastIndexOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.String._lastIndexOf20631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._lastIndexOf20631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring20632;
		public global::java.lang.String substring(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._substring20632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._substring20632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring20633;
		public global::java.lang.String substring(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._substring20633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._substring20633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence20634;
		public global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._subSequence20634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._subSequence20634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _concat20635;
		public global::java.lang.String concat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._concat20635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._concat20635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replace20636;
		public global::java.lang.String replace(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replace20636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replace20636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replace20637;
		public global::java.lang.String replace(java.lang.CharSequence arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replace20637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replace20637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public java.lang.String replace(string arg0, string arg1)
		{
			return replace((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _matches20638;
		public bool matches(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._matches20638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._matches20638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains20639;
		public bool contains(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.String._contains20639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._contains20639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool contains(string arg0)
		{
			return contains((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _replaceFirst20640;
		public global::java.lang.String replaceFirst(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replaceFirst20640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replaceFirst20640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll20641;
		public global::java.lang.String replaceAll(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._replaceAll20641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._replaceAll20641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _split20642;
		public global::java.lang.String[] split(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._split20642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._split20642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _split20643;
		public global::java.lang.String[] split(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._split20643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._split20643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase20644;
		public global::java.lang.String toLowerCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toLowerCase20644)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toLowerCase20644)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase20645;
		public global::java.lang.String toLowerCase(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toLowerCase20645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toLowerCase20645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase20646;
		public global::java.lang.String toUpperCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toUpperCase20646)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toUpperCase20646)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase20647;
		public global::java.lang.String toUpperCase(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toUpperCase20647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toUpperCase20647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _trim20648;
		public global::java.lang.String trim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._trim20648)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._trim20648)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray20649;
		public char[] toCharArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._toCharArray20649)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._toCharArray20649)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _format20650;
		public static global::java.lang.String format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._format20650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format20651;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._format20651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20652;
		public static global::java.lang.String valueOf(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20653;
		public static global::java.lang.String valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20654;
		public static global::java.lang.String valueOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20655;
		public static global::java.lang.String valueOf(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20656;
		public static global::java.lang.String valueOf(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20657;
		public static global::java.lang.String valueOf(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20658;
		public static global::java.lang.String valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20659;
		public static global::java.lang.String valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20660;
		public static global::java.lang.String valueOf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._valueOf20660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _copyValueOf20661;
		public static global::java.lang.String copyValueOf(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._copyValueOf20661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _copyValueOf20662;
		public static global::java.lang.String copyValueOf(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._copyValueOf20662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _intern20663;
		public global::java.lang.String intern()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.String._intern20663)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.String.staticClass, global::java.lang.String._intern20663)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _String20664;
		public String() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20664);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20665;
		public String(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20666;
		public String(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20667;
		public String(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20668;
		public String(int[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20669;
		public String(byte[] arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20670;
		public String(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20671;
		public String(byte[] arg0, java.nio.charset.Charset arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20672;
		public String(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20673;
		public String(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20674;
		public String(java.lang.StringBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20675;
		public String(java.lang.StringBuilder arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20676;
		public String(byte[] arg0, int arg1, int arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20677;
		public String(byte[] arg0, int arg1, int arg2, java.nio.charset.Charset arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _String20678;
		public String(byte[] arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._String20678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CASE_INSENSITIVE_ORDER20679;
		public static global::java.util.Comparator CASE_INSENSITIVE_ORDER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.GetStaticObjectField(global::java.lang.String.staticClass, _CASE_INSENSITIVE_ORDER20679)) as java.util.Comparator;
			}
		}
		static String()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.String.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/String"));
			global::java.lang.String._equals20598 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.String._toString20599 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.String._hashCode20600 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "hashCode", "()I");
			global::java.lang.String._compareTo20601 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.String._compareTo20602 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "compareTo", "(Ljava/lang/String;)I");
			global::java.lang.String._indexOf20603 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(I)I");
			global::java.lang.String._indexOf20604 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.String._indexOf20605 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.String._indexOf20606 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "indexOf", "(II)I");
			global::java.lang.String._length20607 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "length", "()I");
			global::java.lang.String._isEmpty20608 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "isEmpty", "()Z");
			global::java.lang.String._charAt20609 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "charAt", "(I)C");
			global::java.lang.String._codePointAt20610 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "codePointAt", "(I)I");
			global::java.lang.String._codePointBefore20611 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "codePointBefore", "(I)I");
			global::java.lang.String._codePointCount20612 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "codePointCount", "(II)I");
			global::java.lang.String._offsetByCodePoints20613 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.String._getChars20614 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getChars", "(II[CI)V");
			global::java.lang.String._getBytes20615 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "(II[BI)V");
			global::java.lang.String._getBytes20616 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "(Ljava/nio/charset/Charset;)[B");
			global::java.lang.String._getBytes20617 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "()[B");
			global::java.lang.String._getBytes20618 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.lang.String._contentEquals20619 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "contentEquals", "(Ljava/lang/StringBuffer;)Z");
			global::java.lang.String._contentEquals20620 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "contentEquals", "(Ljava/lang/CharSequence;)Z");
			global::java.lang.String._equalsIgnoreCase20621 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "equalsIgnoreCase", "(Ljava/lang/String;)Z");
			global::java.lang.String._compareToIgnoreCase20622 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "compareToIgnoreCase", "(Ljava/lang/String;)I");
			global::java.lang.String._regionMatches20623 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "regionMatches", "(ZILjava/lang/String;II)Z");
			global::java.lang.String._regionMatches20624 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "regionMatches", "(ILjava/lang/String;II)Z");
			global::java.lang.String._startsWith20625 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "startsWith", "(Ljava/lang/String;)Z");
			global::java.lang.String._startsWith20626 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "startsWith", "(Ljava/lang/String;I)Z");
			global::java.lang.String._endsWith20627 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "endsWith", "(Ljava/lang/String;)Z");
			global::java.lang.String._lastIndexOf20628 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.String._lastIndexOf20629 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(II)I");
			global::java.lang.String._lastIndexOf20630 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(I)I");
			global::java.lang.String._lastIndexOf20631 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.String._substring20632 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.String._substring20633 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.String._subSequence20634 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.String._concat20635 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "concat", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.String._replace20636 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replace", "(CC)Ljava/lang/String;");
			global::java.lang.String._replace20637 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;");
			global::java.lang.String._matches20638 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "matches", "(Ljava/lang/String;)Z");
			global::java.lang.String._contains20639 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "contains", "(Ljava/lang/CharSequence;)Z");
			global::java.lang.String._replaceFirst20640 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.String._replaceAll20641 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.String._split20642 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "split", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::java.lang.String._split20643 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "split", "(Ljava/lang/String;I)[Ljava/lang/String;");
			global::java.lang.String._toLowerCase20644 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toLowerCase", "()Ljava/lang/String;");
			global::java.lang.String._toLowerCase20645 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.lang.String._toUpperCase20646 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toUpperCase", "()Ljava/lang/String;");
			global::java.lang.String._toUpperCase20647 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.lang.String._trim20648 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "trim", "()Ljava/lang/String;");
			global::java.lang.String._toCharArray20649 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "toCharArray", "()[C");
			global::java.lang.String._format20650 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			global::java.lang.String._format20651 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			global::java.lang.String._valueOf20652 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "([C)Ljava/lang/String;");
			global::java.lang.String._valueOf20653 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(D)Ljava/lang/String;");
			global::java.lang.String._valueOf20654 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;");
			global::java.lang.String._valueOf20655 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "([CII)Ljava/lang/String;");
			global::java.lang.String._valueOf20656 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(Z)Ljava/lang/String;");
			global::java.lang.String._valueOf20657 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(C)Ljava/lang/String;");
			global::java.lang.String._valueOf20658 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(I)Ljava/lang/String;");
			global::java.lang.String._valueOf20659 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(J)Ljava/lang/String;");
			global::java.lang.String._valueOf20660 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(F)Ljava/lang/String;");
			global::java.lang.String._copyValueOf20661 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "copyValueOf", "([CII)Ljava/lang/String;");
			global::java.lang.String._copyValueOf20662 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "copyValueOf", "([C)Ljava/lang/String;");
			global::java.lang.String._intern20663 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "intern", "()Ljava/lang/String;");
			global::java.lang.String._String20664 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "()V");
			global::java.lang.String._String20665 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.String._String20666 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([C)V");
			global::java.lang.String._String20667 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([CII)V");
			global::java.lang.String._String20668 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([III)V");
			global::java.lang.String._String20669 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIII)V");
			global::java.lang.String._String20670 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BI)V");
			global::java.lang.String._String20671 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BLjava/nio/charset/Charset;)V");
			global::java.lang.String._String20672 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BII)V");
			global::java.lang.String._String20673 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([B)V");
			global::java.lang.String._String20674 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/StringBuffer;)V");
			global::java.lang.String._String20675 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V");
			global::java.lang.String._String20676 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIILjava/lang/String;)V");
			global::java.lang.String._String20677 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIILjava/nio/charset/Charset;)V");
			global::java.lang.String._String20678 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BLjava/lang/String;)V");
			global::java.lang.String._CASE_INSENSITIVE_ORDER20679 = @__env.GetStaticFieldIDNoThrow(global::java.lang.String.staticClass, "CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
