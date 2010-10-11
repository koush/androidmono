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
		internal static global::MonoJavaBridge.MethodId _toString13278;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._toString13278)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._toString13278)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append13279;
		public new global::java.lang.StringBuilder append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append13280;
		public new global::java.lang.StringBuilder append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append13281;
		public new global::java.lang.StringBuilder append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13282;
		public new global::java.lang.StringBuilder append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13283;
		public new global::java.lang.StringBuilder append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13284;
		public new global::java.lang.StringBuilder append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13285;
		public new global::java.lang.StringBuilder append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13286;
		public new global::java.lang.StringBuilder append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13287;
		public new global::java.lang.StringBuilder append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13288;
		public new global::java.lang.StringBuilder append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13289;
		public new global::java.lang.StringBuilder append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13290;
		public new global::java.lang.StringBuilder append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append13291;
		public new global::java.lang.StringBuilder append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append13291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append13291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13292;
		public sealed override int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf13292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf13292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13293;
		public sealed override int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf13293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf13293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length13294;
		public sealed override int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._length13294);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._length13294);
		}
		internal static global::MonoJavaBridge.MethodId _charAt13295;
		public sealed override char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.StringBuilder._charAt13295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._charAt13295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13296;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf13296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf13296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13297;
		public sealed override int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf13297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf13297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence13298;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._subSequence13298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._subSequence13298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace13299;
		public new global::java.lang.StringBuilder replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._replace13299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._replace13299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint13300;
		public new global::java.lang.StringBuilder appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._appendCodePoint13300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._appendCodePoint13300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete13301;
		public new global::java.lang.StringBuilder delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._delete13301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._delete13301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt13302;
		public new global::java.lang.StringBuilder deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._deleteCharAt13302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._deleteCharAt13302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13303;
		public new global::java.lang.StringBuilder insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13304;
		public new global::java.lang.StringBuilder insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13305;
		public new global::java.lang.StringBuilder insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13306;
		public new global::java.lang.StringBuilder insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13307;
		public new global::java.lang.StringBuilder insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13308;
		public new global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert13309;
		public new global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert13310;
		public new global::java.lang.StringBuilder insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13311;
		public new global::java.lang.StringBuilder insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13312;
		public new global::java.lang.StringBuilder insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13313;
		public new global::java.lang.StringBuilder insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert13314;
		public new global::java.lang.StringBuilder insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert13314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert13314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse13315;
		public new global::java.lang.StringBuilder reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._reverse13315)) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._reverse13315)) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder13316;
		public StringBuilder(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder13316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder13317;
		public StringBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder13317);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder13318;
		public StringBuilder(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder13318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder13319;
		public StringBuilder(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder13319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuilder"));
			global::java.lang.StringBuilder._toString13278 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuilder._append13279 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13280 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13281 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13282 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Z)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13283 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13284 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13285 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(J)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13286 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(F)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13287 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(D)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13288 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13289 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13290 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append13291 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._indexOf13292 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._indexOf13293 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._length13294 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "length", "()I");
			global::java.lang.StringBuilder._charAt13295 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuilder._lastIndexOf13296 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._lastIndexOf13297 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._subSequence13298 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuilder._replace13299 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._appendCodePoint13300 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._delete13301 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "delete", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._deleteCharAt13302 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13303 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ID)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13304 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13305 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13306 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13307 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13308 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13309 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13310 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IZ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13311 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IC)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13312 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13313 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IJ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert13314 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IF)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._reverse13315 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "reverse", "()Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._StringBuilder13316 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuilder._StringBuilder13317 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
			global::java.lang.StringBuilder._StringBuilder13318 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuilder._StringBuilder13319 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
