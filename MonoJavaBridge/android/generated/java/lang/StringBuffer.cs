namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringBuffer : java.lang.AbstractStringBuilder, java.io.Serializable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StringBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString20680;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._toString20680)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append20681;
		public global::java.lang.StringBuffer append(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20682;
		public global::java.lang.StringBuffer append(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20683;
		public global::java.lang.StringBuffer append(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20684;
		public global::java.lang.StringBuffer append(java.lang.StringBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20685;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append20686;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append20687;
		public global::java.lang.StringBuffer append(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20688;
		public global::java.lang.StringBuffer append(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20689;
		public global::java.lang.StringBuffer append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20690;
		public global::java.lang.StringBuffer append(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20691;
		public global::java.lang.StringBuffer append(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20692;
		public global::java.lang.StringBuffer append(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20693;
		public global::java.lang.StringBuffer append(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20694;
		public sealed override int indexOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._indexOf20694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20695;
		public sealed override int indexOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._indexOf20695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length20696;
		public sealed override int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._length20696);
		}
		internal static global::MonoJavaBridge.MethodId _charAt20697;
		public sealed override char charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._charAt20697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt20698;
		public sealed override int codePointAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointAt20698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore20699;
		public sealed override int codePointBefore(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointBefore20699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount20700;
		public sealed override int codePointCount(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointCount20700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints20701;
		public sealed override int offsetByCodePoints(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._offsetByCodePoints20701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars20702;
		public sealed override void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._getChars20702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20703;
		public sealed override int lastIndexOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._lastIndexOf20703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20704;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._lastIndexOf20704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _substring20705;
		public sealed override global::java.lang.String substring(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._substring20705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring20706;
		public sealed override global::java.lang.String substring(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._substring20706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence20707;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._subSequence20707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace20708;
		public global::java.lang.StringBuffer replace(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._replace20708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize20709;
		public sealed override void trimToSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._trimToSize20709);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity20710;
		public sealed override void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._ensureCapacity20710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity20711;
		public sealed override int capacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._capacity20711);
		}
		internal static global::MonoJavaBridge.MethodId _setLength20712;
		public sealed override void setLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._setLength20712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt20713;
		public sealed override void setCharAt(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._setCharAt20713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint20714;
		public global::java.lang.StringBuffer appendCodePoint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._appendCodePoint20714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _delete20715;
		public global::java.lang.StringBuffer delete(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._delete20715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt20716;
		public global::java.lang.StringBuffer deleteCharAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._deleteCharAt20716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20717;
		public global::java.lang.StringBuffer insert(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20718;
		public global::java.lang.StringBuffer insert(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20719;
		public global::java.lang.StringBuffer insert(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20720;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert20721;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert20722;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20723;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20724;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20725;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20726;
		public global::java.lang.StringBuffer insert(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20727;
		public global::java.lang.StringBuffer insert(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20728;
		public global::java.lang.StringBuffer insert(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20729;
		public global::java.lang.StringBuffer reverse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._reverse20729)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20730;
		public StringBuffer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20730);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20731;
		public StringBuffer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20732;
		public StringBuffer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20733;
		public StringBuffer(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuffer"));
			global::java.lang.StringBuffer._toString20680 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuffer._append20681 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "([CII)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20682 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20683 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20684 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20685 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20686 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20687 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "([C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20688 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Z)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20689 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20690 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20691 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(J)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20692 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(F)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20693 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(D)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._indexOf20694 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuffer._indexOf20695 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuffer._length20696 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "length", "()I");
			global::java.lang.StringBuffer._charAt20697 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuffer._codePointAt20698 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointAt", "(I)I");
			global::java.lang.StringBuffer._codePointBefore20699 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointBefore", "(I)I");
			global::java.lang.StringBuffer._codePointCount20700 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointCount", "(II)I");
			global::java.lang.StringBuffer._offsetByCodePoints20701 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.StringBuffer._getChars20702 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "getChars", "(II[CI)V");
			global::java.lang.StringBuffer._lastIndexOf20703 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuffer._lastIndexOf20704 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuffer._substring20705 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.StringBuffer._substring20706 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.StringBuffer._subSequence20707 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuffer._replace20708 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._trimToSize20709 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "trimToSize", "()V");
			global::java.lang.StringBuffer._ensureCapacity20710 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "ensureCapacity", "(I)V");
			global::java.lang.StringBuffer._capacity20711 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "capacity", "()I");
			global::java.lang.StringBuffer._setLength20712 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "setLength", "(I)V");
			global::java.lang.StringBuffer._setCharAt20713 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "setCharAt", "(IC)V");
			global::java.lang.StringBuffer._appendCodePoint20714 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._delete20715 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "delete", "(II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._deleteCharAt20716 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20717 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20718 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IC)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20719 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IZ)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20720 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20721 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20722 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(I[C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20723 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20724 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20725 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(I[CII)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20726 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ID)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20727 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IF)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20728 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IJ)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._reverse20729 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "reverse", "()Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._StringBuffer20730 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "()V");
			global::java.lang.StringBuffer._StringBuffer20731 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuffer._StringBuffer20732 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuffer._StringBuffer20733 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
