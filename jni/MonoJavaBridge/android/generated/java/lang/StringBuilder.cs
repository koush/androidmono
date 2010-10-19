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
		internal static global::MonoJavaBridge.MethodId _toString15096;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._toString15096)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._toString15096)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append15097;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append15098;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append15099;
		public global::java.lang.StringBuilder append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15100;
		public global::java.lang.StringBuilder append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15101;
		public global::java.lang.StringBuilder append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15102;
		public global::java.lang.StringBuilder append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15103;
		public global::java.lang.StringBuilder append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15104;
		public global::java.lang.StringBuilder append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15105;
		public global::java.lang.StringBuilder append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15106;
		public global::java.lang.StringBuilder append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15107;
		public global::java.lang.StringBuilder append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15108;
		public global::java.lang.StringBuilder append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append15109;
		public global::java.lang.StringBuilder append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._append15109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._append15109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf15110;
		public sealed override int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf15110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf15110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf15111;
		public sealed override int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._indexOf15111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._indexOf15111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length15112;
		public sealed override int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._length15112);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._length15112);
		}
		internal static global::MonoJavaBridge.MethodId _charAt15113;
		public sealed override char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.StringBuilder._charAt15113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._charAt15113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf15114;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf15114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf15114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf15115;
		public sealed override int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuilder._lastIndexOf15115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._lastIndexOf15115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence15116;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._subSequence15116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._subSequence15116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace15117;
		public global::java.lang.StringBuilder replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._replace15117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._replace15117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint15118;
		public global::java.lang.StringBuilder appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._appendCodePoint15118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._appendCodePoint15118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete15119;
		public global::java.lang.StringBuilder delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._delete15119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._delete15119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt15120;
		public global::java.lang.StringBuilder deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._deleteCharAt15120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._deleteCharAt15120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15121;
		public global::java.lang.StringBuilder insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15122;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15123;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15124;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15125;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15126;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert15127;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert15128;
		public global::java.lang.StringBuilder insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15129;
		public global::java.lang.StringBuilder insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15130;
		public global::java.lang.StringBuilder insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15131;
		public global::java.lang.StringBuilder insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert15132;
		public global::java.lang.StringBuilder insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._insert15132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._insert15132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse15133;
		public global::java.lang.StringBuilder reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuilder._reverse15133)) as java.lang.StringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._reverse15133)) as java.lang.StringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder15134;
		public StringBuilder(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder15134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder15135;
		public StringBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder15135);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder15136;
		public StringBuilder(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder15136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilder15137;
		public StringBuilder(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._StringBuilder15137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuilder"));
			global::java.lang.StringBuilder._toString15096 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuilder._append15097 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15098 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15099 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15100 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Z)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15101 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15102 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15103 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(J)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15104 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(F)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15105 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(D)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15106 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "([CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15107 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15108 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._append15109 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._indexOf15110 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._indexOf15111 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._length15112 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "length", "()I");
			global::java.lang.StringBuilder._charAt15113 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuilder._lastIndexOf15114 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuilder._lastIndexOf15115 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuilder._subSequence15116 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuilder._replace15117 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._appendCodePoint15118 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._delete15119 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "delete", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._deleteCharAt15120 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15121 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ID)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15122 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15123 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15124 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15125 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(I[C)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15126 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15127 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15128 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IZ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15129 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IC)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15130 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(II)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15131 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IJ)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._insert15132 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "insert", "(IF)Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._reverse15133 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "reverse", "()Ljava/lang/StringBuilder;");
			global::java.lang.StringBuilder._StringBuilder15134 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuilder._StringBuilder15135 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
			global::java.lang.StringBuilder._StringBuilder15136 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuilder._StringBuilder15137 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
