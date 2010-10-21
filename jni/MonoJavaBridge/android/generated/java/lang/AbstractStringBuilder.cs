namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.AbstractStringBuilder_))]
	public abstract partial class AbstractStringBuilder : java.lang.Object, Appendable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractStringBuilder()
		{
			InitJNI();
		}
		protected AbstractStringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19538;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _append19539;
		public virtual global::java.lang.AbstractStringBuilder append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19540;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19541;
		public virtual global::java.lang.AbstractStringBuilder append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19542;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append19543;
		public virtual global::java.lang.AbstractStringBuilder append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19544;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19545;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append19546;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19547;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19548;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19549;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19550;
		public virtual global::java.lang.AbstractStringBuilder append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19551;
		public virtual global::java.lang.AbstractStringBuilder append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append19551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append19551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf19552;
		public virtual int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._indexOf19552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._indexOf19552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf19553;
		public virtual int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._indexOf19553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._indexOf19553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length19554;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._length19554);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._length19554);
		}
		internal static global::MonoJavaBridge.MethodId _charAt19555;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._charAt19555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._charAt19555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19556;
		public virtual int codePointAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointAt19556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointAt19556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19557;
		public virtual int codePointBefore(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointBefore19557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointBefore19557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount19558;
		public virtual int codePointCount(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointCount19558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointCount19558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints19559;
		public virtual int offsetByCodePoints(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._offsetByCodePoints19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._offsetByCodePoints19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars19560;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._getChars19560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._getChars19560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf19561;
		public virtual int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._lastIndexOf19561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._lastIndexOf19561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf19562;
		public virtual int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._lastIndexOf19562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._lastIndexOf19562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring19563;
		public virtual global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._substring19563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._substring19563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring19564;
		public virtual global::java.lang.String substring(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._substring19564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._substring19564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence19565;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._subSequence19565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._subSequence19565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace19566;
		public virtual global::java.lang.AbstractStringBuilder replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._replace19566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._replace19566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize19567;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._trimToSize19567);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._trimToSize19567);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity19568;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._ensureCapacity19568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._ensureCapacity19568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity19569;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._capacity19569);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._capacity19569);
		}
		internal static global::MonoJavaBridge.MethodId _setLength19570;
		public virtual void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._setLength19570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._setLength19570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt19571;
		public virtual void setCharAt(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._setCharAt19571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._setCharAt19571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint19572;
		public virtual global::java.lang.AbstractStringBuilder appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._appendCodePoint19572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._appendCodePoint19572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete19573;
		public virtual global::java.lang.AbstractStringBuilder delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._delete19573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._delete19573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt19574;
		public virtual global::java.lang.AbstractStringBuilder deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._deleteCharAt19574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._deleteCharAt19574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19575;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19576;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19577;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19578;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19579;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19580;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19581;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19582;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19583;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19584;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert19585;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert19586;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert19586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert19586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse19587;
		public virtual global::java.lang.AbstractStringBuilder reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._reverse19587)) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._reverse19587)) as java.lang.AbstractStringBuilder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
			global::java.lang.AbstractStringBuilder._toString19538 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._append19539 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(J)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19540 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append19541 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19542 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append19543 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Z)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19544 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "([CII)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19545 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append19546 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19547 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19548 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19549 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "([C)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19550 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(D)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append19551 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(F)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._indexOf19552 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.AbstractStringBuilder._indexOf19553 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.AbstractStringBuilder._length19554 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "length", "()I");
			global::java.lang.AbstractStringBuilder._charAt19555 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.AbstractStringBuilder._codePointAt19556 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointAt", "(I)I");
			global::java.lang.AbstractStringBuilder._codePointBefore19557 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointBefore", "(I)I");
			global::java.lang.AbstractStringBuilder._codePointCount19558 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointCount", "(II)I");
			global::java.lang.AbstractStringBuilder._offsetByCodePoints19559 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.AbstractStringBuilder._getChars19560 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "getChars", "(II[CI)V");
			global::java.lang.AbstractStringBuilder._lastIndexOf19561 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.AbstractStringBuilder._lastIndexOf19562 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.AbstractStringBuilder._substring19563 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._substring19564 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._subSequence19565 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.AbstractStringBuilder._replace19566 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._trimToSize19567 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "trimToSize", "()V");
			global::java.lang.AbstractStringBuilder._ensureCapacity19568 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "ensureCapacity", "(I)V");
			global::java.lang.AbstractStringBuilder._capacity19569 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "capacity", "()I");
			global::java.lang.AbstractStringBuilder._setLength19570 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "setLength", "(I)V");
			global::java.lang.AbstractStringBuilder._setCharAt19571 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "setCharAt", "(IC)V");
			global::java.lang.AbstractStringBuilder._appendCodePoint19572 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._delete19573 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "delete", "(II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._deleteCharAt19574 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19575 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IC)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19576 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19577 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IJ)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19578 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IF)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19579 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ID)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19580 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19581 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19582 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19583 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[C)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19584 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19585 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert19586 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IZ)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._reverse19587 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "reverse", "()Ljava/lang/AbstractStringBuilder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.AbstractStringBuilder))]
	public sealed partial class AbstractStringBuilder_ : java.lang.AbstractStringBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractStringBuilder_()
		{
			InitJNI();
		}
		internal AbstractStringBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19588;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder_._toString19588)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder_.staticClass, global::java.lang.AbstractStringBuilder_._toString19588)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
			global::java.lang.AbstractStringBuilder_._toString19588 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder_.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
