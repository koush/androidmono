namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringBuilder : java.lang.AbstractStringBuilder, java.io.Serializable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringBuilder()
		{
			InitJNI();
		}
		internal StringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString20734;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._toString20734)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._toString20734)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append20735;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append20736;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append20737;
		public global::java.lang.StringBuilder append(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20738;
		public global::java.lang.StringBuilder append(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20739;
		public global::java.lang.StringBuilder append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20740;
		public global::java.lang.StringBuilder append(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20741;
		public global::java.lang.StringBuilder append(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20742;
		public global::java.lang.StringBuilder append(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20743;
		public global::java.lang.StringBuilder append(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20744;
		public global::java.lang.StringBuilder append(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20745;
		public global::java.lang.StringBuilder append(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20746;
		public global::java.lang.StringBuilder append(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20747;
		public global::java.lang.StringBuilder append(java.lang.StringBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20748;
		public sealed override int indexOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf20748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf20748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20749;
		public sealed override int indexOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf20749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf20749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length20750;
		public sealed override int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._length20750);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._length20750);
		}
		internal static global::MonoJavaBridge.MethodId _charAt20751;
		public sealed override char charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.StringBuilder._charAt20751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._charAt20751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20752;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf20752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf20752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20753;
		public sealed override int lastIndexOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf20753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf20753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence20754;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._subSequence20754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._subSequence20754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace20755;
		public global::java.lang.StringBuilder replace(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._replace20755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._replace20755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint20756;
		public global::java.lang.StringBuilder appendCodePoint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._appendCodePoint20756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._appendCodePoint20756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete20757;
		public global::java.lang.StringBuilder delete(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._delete20757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._delete20757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt20758;
		public global::java.lang.StringBuilder deleteCharAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._deleteCharAt20758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._deleteCharAt20758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20759;
		public global::java.lang.StringBuilder insert(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20760;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20761;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20762;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20763;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20764;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert20765;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert20766;
		public global::java.lang.StringBuilder insert(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20767;
		public global::java.lang.StringBuilder insert(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20768;
		public global::java.lang.StringBuilder insert(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20769;
		public global::java.lang.StringBuilder insert(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20770;
		public global::java.lang.StringBuilder insert(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20771;
		public global::java.lang.StringBuilder reverse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._reverse20771)) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._reverse20771)) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20772;
		public StringBuilder(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20773;
		public StringBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20773);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20774;
		public StringBuilder(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20775;
		public StringBuilder(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuilder"));
			global::java.lang.StringBuilder._toString20734 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuilder._append20735 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20736 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20737 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20738 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Z)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20739 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20740 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20741 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(J)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20742 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(F)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20743 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(D)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20744 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20745 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20746 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20747 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._indexOf20748 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._indexOf20749 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._length20750 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "length", "()I");
			global::java.lang.StringBuilder._charAt20751 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuilder._lastIndexOf20752 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._lastIndexOf20753 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._subSequence20754 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuilder._replace20755 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._appendCodePoint20756 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._delete20757 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "delete", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._deleteCharAt20758 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20759 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ID)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20760 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20761 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20762 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20763 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20764 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20765 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20766 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IZ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20767 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IC)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20768 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20769 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IJ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20770 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IF)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._reverse20771 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "reverse", "()Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._StringBuilder20772 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuilder._StringBuilder20773 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
			global::java.lang.StringBuilder._StringBuilder20774 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuilder._StringBuilder20775 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
