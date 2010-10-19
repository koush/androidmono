namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringBuffer : java.lang.AbstractStringBuilder, java.io.Serializable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringBuffer()
		{
			InitJNI();
		}
		internal StringBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15042;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._toString15042)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._toString15042)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append15043;
		public global::java.lang.StringBuffer append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15044;
		public global::java.lang.StringBuffer append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15045;
		public global::java.lang.StringBuffer append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15046;
		public global::java.lang.StringBuffer append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15047;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append15048;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append15049;
		public global::java.lang.StringBuffer append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15050;
		public global::java.lang.StringBuffer append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15051;
		public global::java.lang.StringBuffer append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15052;
		public global::java.lang.StringBuffer append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15053;
		public global::java.lang.StringBuffer append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15054;
		public global::java.lang.StringBuffer append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append15055;
		public global::java.lang.StringBuffer append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append15055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append15055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf15056;
		public sealed override int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._indexOf15056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._indexOf15056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf15057;
		public sealed override int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._indexOf15057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._indexOf15057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length15058;
		public sealed override int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._length15058);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._length15058);
		}
		internal static global::MonoJavaBridge.MethodId _charAt15059;
		public sealed override char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.StringBuffer._charAt15059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._charAt15059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt15060;
		public sealed override int codePointAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._codePointAt15060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointAt15060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore15061;
		public sealed override int codePointBefore(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._codePointBefore15061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointBefore15061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount15062;
		public sealed override int codePointCount(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._codePointCount15062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointCount15062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints15063;
		public sealed override int offsetByCodePoints(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._offsetByCodePoints15063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._offsetByCodePoints15063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars15064;
		public sealed override void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._getChars15064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._getChars15064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf15065;
		public sealed override int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._lastIndexOf15065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._lastIndexOf15065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf15066;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._lastIndexOf15066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._lastIndexOf15066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _substring15067;
		public sealed override global::java.lang.String substring(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._substring15067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._substring15067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring15068;
		public sealed override global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._substring15068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._substring15068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence15069;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._subSequence15069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._subSequence15069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace15070;
		public global::java.lang.StringBuffer replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._replace15070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._replace15070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize15071;
		public sealed override void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._trimToSize15071);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._trimToSize15071);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity15072;
		public sealed override void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._ensureCapacity15072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._ensureCapacity15072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity15073;
		public sealed override int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._capacity15073);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._capacity15073);
		}
		internal static global::MonoJavaBridge.MethodId _setLength15074;
		public sealed override void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._setLength15074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._setLength15074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt15075;
		public sealed override void setCharAt(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._setCharAt15075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._setCharAt15075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint15076;
		public global::java.lang.StringBuffer appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._appendCodePoint15076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._appendCodePoint15076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _delete15077;
		public global::java.lang.StringBuffer delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._delete15077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._delete15077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt15078;
		public global::java.lang.StringBuffer deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._deleteCharAt15078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._deleteCharAt15078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15079;
		public global::java.lang.StringBuffer insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15080;
		public global::java.lang.StringBuffer insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15081;
		public global::java.lang.StringBuffer insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15082;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert15083;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert15084;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15085;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15086;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15087;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15088;
		public global::java.lang.StringBuffer insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15089;
		public global::java.lang.StringBuffer insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert15090;
		public global::java.lang.StringBuffer insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert15090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert15090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse15091;
		public global::java.lang.StringBuffer reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._reverse15091)) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._reverse15091)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer15092;
		public StringBuffer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer15092);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer15093;
		public StringBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer15093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer15094;
		public StringBuffer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer15094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer15095;
		public StringBuffer(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer15095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuffer"));
			global::java.lang.StringBuffer._toString15042 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuffer._append15043 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "([CII)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15044 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15045 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15046 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15047 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15048 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15049 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "([C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15050 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Z)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15051 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15052 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15053 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(J)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15054 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(F)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append15055 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(D)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._indexOf15056 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuffer._indexOf15057 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuffer._length15058 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "length", "()I");
			global::java.lang.StringBuffer._charAt15059 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuffer._codePointAt15060 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointAt", "(I)I");
			global::java.lang.StringBuffer._codePointBefore15061 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointBefore", "(I)I");
			global::java.lang.StringBuffer._codePointCount15062 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointCount", "(II)I");
			global::java.lang.StringBuffer._offsetByCodePoints15063 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.StringBuffer._getChars15064 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "getChars", "(II[CI)V");
			global::java.lang.StringBuffer._lastIndexOf15065 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuffer._lastIndexOf15066 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuffer._substring15067 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.StringBuffer._substring15068 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.StringBuffer._subSequence15069 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuffer._replace15070 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._trimToSize15071 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "trimToSize", "()V");
			global::java.lang.StringBuffer._ensureCapacity15072 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "ensureCapacity", "(I)V");
			global::java.lang.StringBuffer._capacity15073 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "capacity", "()I");
			global::java.lang.StringBuffer._setLength15074 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "setLength", "(I)V");
			global::java.lang.StringBuffer._setCharAt15075 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "setCharAt", "(IC)V");
			global::java.lang.StringBuffer._appendCodePoint15076 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._delete15077 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "delete", "(II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._deleteCharAt15078 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15079 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15080 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IC)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15081 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IZ)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15082 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15083 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15084 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(I[C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15085 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15086 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15087 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(I[CII)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15088 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ID)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15089 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IF)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert15090 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IJ)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._reverse15091 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "reverse", "()Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._StringBuffer15092 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "()V");
			global::java.lang.StringBuffer._StringBuffer15093 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuffer._StringBuffer15094 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuffer._StringBuffer15095 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
