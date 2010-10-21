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
		internal static global::MonoJavaBridge.MethodId _toString20615;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._toString20615)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._toString20615)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append20616;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append20617;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append20618;
		public global::java.lang.StringBuilder append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20619;
		public global::java.lang.StringBuilder append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20620;
		public global::java.lang.StringBuilder append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20621;
		public global::java.lang.StringBuilder append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20622;
		public global::java.lang.StringBuilder append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20623;
		public global::java.lang.StringBuilder append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20624;
		public global::java.lang.StringBuilder append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20625;
		public global::java.lang.StringBuilder append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20626;
		public global::java.lang.StringBuilder append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20627;
		public global::java.lang.StringBuilder append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append20628;
		public global::java.lang.StringBuilder append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append20628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append20628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20629;
		public sealed override int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf20629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf20629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20630;
		public sealed override int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf20630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf20630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length20631;
		public sealed override int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._length20631);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._length20631);
		}
		internal static global::MonoJavaBridge.MethodId _charAt20632;
		public sealed override char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.StringBuilder._charAt20632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._charAt20632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20633;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf20633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf20633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20634;
		public sealed override int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf20634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf20634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence20635;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._subSequence20635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._subSequence20635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace20636;
		public global::java.lang.StringBuilder replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._replace20636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._replace20636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint20637;
		public global::java.lang.StringBuilder appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._appendCodePoint20637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._appendCodePoint20637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete20638;
		public global::java.lang.StringBuilder delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._delete20638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._delete20638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt20639;
		public global::java.lang.StringBuilder deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._deleteCharAt20639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._deleteCharAt20639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20640;
		public global::java.lang.StringBuilder insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20641;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20642;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20643;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20644;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20645;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert20646;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert20647;
		public global::java.lang.StringBuilder insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20648;
		public global::java.lang.StringBuilder insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20649;
		public global::java.lang.StringBuilder insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20650;
		public global::java.lang.StringBuilder insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert20651;
		public global::java.lang.StringBuilder insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert20651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert20651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20652;
		public global::java.lang.StringBuilder reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._reverse20652)) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._reverse20652)) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20653;
		public StringBuilder(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20654;
		public StringBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20654);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20655;
		public StringBuilder(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder20656;
		public StringBuilder(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder20656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuilder"));
			global::java.lang.StringBuilder._toString20615 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuilder._append20616 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20617 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20618 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20619 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Z)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20620 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20621 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20622 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(J)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20623 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(F)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20624 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(D)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20625 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20626 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20627 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append20628 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._indexOf20629 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._indexOf20630 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._length20631 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "length", "()I");
			global::java.lang.StringBuilder._charAt20632 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuilder._lastIndexOf20633 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._lastIndexOf20634 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._subSequence20635 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuilder._replace20636 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._appendCodePoint20637 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._delete20638 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "delete", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._deleteCharAt20639 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20640 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ID)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20641 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20642 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20643 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20644 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20645 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20646 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20647 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IZ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20648 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IC)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20649 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20650 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IJ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert20651 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IF)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._reverse20652 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "reverse", "()Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._StringBuilder20653 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuilder._StringBuilder20654 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
			global::java.lang.StringBuilder._StringBuilder20655 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuilder._StringBuilder20656 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
