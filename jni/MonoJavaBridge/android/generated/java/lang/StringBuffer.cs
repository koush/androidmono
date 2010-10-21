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
		internal static global::MonoJavaBridge.MethodId _toString20561;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._toString20561)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._toString20561)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append20562;
		public global::java.lang.StringBuffer append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20563;
		public global::java.lang.StringBuffer append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20564;
		public global::java.lang.StringBuffer append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20565;
		public global::java.lang.StringBuffer append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20566;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append20567;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append20568;
		public global::java.lang.StringBuffer append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20569;
		public global::java.lang.StringBuffer append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20570;
		public global::java.lang.StringBuffer append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20571;
		public global::java.lang.StringBuffer append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20572;
		public global::java.lang.StringBuffer append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20573;
		public global::java.lang.StringBuffer append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _append20574;
		public global::java.lang.StringBuffer append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._append20574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._append20574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20575;
		public sealed override int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._indexOf20575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._indexOf20575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20576;
		public sealed override int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._indexOf20576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._indexOf20576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length20577;
		public sealed override int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._length20577);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._length20577);
		}
		internal static global::MonoJavaBridge.MethodId _charAt20578;
		public sealed override char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.StringBuffer._charAt20578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._charAt20578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt20579;
		public sealed override int codePointAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._codePointAt20579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointAt20579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore20580;
		public sealed override int codePointBefore(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._codePointBefore20580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointBefore20580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount20581;
		public sealed override int codePointCount(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._codePointCount20581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._codePointCount20581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints20582;
		public sealed override int offsetByCodePoints(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._offsetByCodePoints20582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._offsetByCodePoints20582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars20583;
		public sealed override void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._getChars20583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._getChars20583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20584;
		public sealed override int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._lastIndexOf20584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._lastIndexOf20584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20585;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._lastIndexOf20585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._lastIndexOf20585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _substring20586;
		public sealed override global::java.lang.String substring(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._substring20586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._substring20586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring20587;
		public sealed override global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._substring20587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._substring20587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence20588;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._subSequence20588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._subSequence20588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace20589;
		public global::java.lang.StringBuffer replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._replace20589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._replace20589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize20590;
		public sealed override void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._trimToSize20590);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._trimToSize20590);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity20591;
		public sealed override void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._ensureCapacity20591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._ensureCapacity20591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity20592;
		public sealed override int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StringBuffer._capacity20592);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._capacity20592);
		}
		internal static global::MonoJavaBridge.MethodId _setLength20593;
		public sealed override void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._setLength20593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._setLength20593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt20594;
		public sealed override void setCharAt(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.StringBuffer._setCharAt20594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._setCharAt20594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint20595;
		public global::java.lang.StringBuffer appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._appendCodePoint20595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._appendCodePoint20595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _delete20596;
		public global::java.lang.StringBuffer delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._delete20596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._delete20596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt20597;
		public global::java.lang.StringBuffer deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._deleteCharAt20597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._deleteCharAt20597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20598;
		public global::java.lang.StringBuffer insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20599;
		public global::java.lang.StringBuffer insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20600;
		public global::java.lang.StringBuffer insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20601;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert20602;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert20603;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20604;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20605;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20606;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20607;
		public global::java.lang.StringBuffer insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20608;
		public global::java.lang.StringBuffer insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _insert20609;
		public global::java.lang.StringBuffer insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._insert20609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._insert20609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20610;
		public global::java.lang.StringBuffer reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StringBuffer._reverse20610)) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._reverse20610)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20611;
		public StringBuffer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20611);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20612;
		public StringBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20613;
		public StringBuffer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringBuffer20614;
		public StringBuffer(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._StringBuffer20614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuffer"));
			global::java.lang.StringBuffer._toString20561 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StringBuffer._append20562 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "([CII)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20563 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20564 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20565 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20566 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20567 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20568 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "([C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20569 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(Z)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20570 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20571 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20572 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(J)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20573 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(F)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._append20574 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "append", "(D)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._indexOf20575 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuffer._indexOf20576 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuffer._length20577 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "length", "()I");
			global::java.lang.StringBuffer._charAt20578 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "charAt", "(I)C");
			global::java.lang.StringBuffer._codePointAt20579 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointAt", "(I)I");
			global::java.lang.StringBuffer._codePointBefore20580 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointBefore", "(I)I");
			global::java.lang.StringBuffer._codePointCount20581 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "codePointCount", "(II)I");
			global::java.lang.StringBuffer._offsetByCodePoints20582 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.StringBuffer._getChars20583 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "getChars", "(II[CI)V");
			global::java.lang.StringBuffer._lastIndexOf20584 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.StringBuffer._lastIndexOf20585 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.StringBuffer._substring20586 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.StringBuffer._substring20587 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.StringBuffer._subSequence20588 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.StringBuffer._replace20589 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._trimToSize20590 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "trimToSize", "()V");
			global::java.lang.StringBuffer._ensureCapacity20591 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "ensureCapacity", "(I)V");
			global::java.lang.StringBuffer._capacity20592 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "capacity", "()I");
			global::java.lang.StringBuffer._setLength20593 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "setLength", "(I)V");
			global::java.lang.StringBuffer._setCharAt20594 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "setCharAt", "(IC)V");
			global::java.lang.StringBuffer._appendCodePoint20595 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._delete20596 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "delete", "(II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._deleteCharAt20597 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20598 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20599 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IC)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20600 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IZ)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20601 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20602 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20603 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(I[C)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20604 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20605 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20606 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(I[CII)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20607 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(ID)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20608 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IF)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._insert20609 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "insert", "(IJ)Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._reverse20610 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "reverse", "()Ljava/lang/StringBuffer;");
			global::java.lang.StringBuffer._StringBuffer20611 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "()V");
			global::java.lang.StringBuffer._StringBuffer20612 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(I)V");
			global::java.lang.StringBuffer._StringBuffer20613 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringBuffer._StringBuffer20614 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
