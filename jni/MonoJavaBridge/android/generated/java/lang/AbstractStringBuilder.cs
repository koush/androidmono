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
		internal static global::MonoJavaBridge.MethodId _toString14032;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _append14033;
		public virtual global::java.lang.AbstractStringBuilder append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14034;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append14035;
		public virtual global::java.lang.AbstractStringBuilder append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14036;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append14037;
		public virtual global::java.lang.AbstractStringBuilder append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14038;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14039;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append14040;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14041;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14042;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14043;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14044;
		public virtual global::java.lang.AbstractStringBuilder append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append14045;
		public virtual global::java.lang.AbstractStringBuilder append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append14045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append14045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf14046;
		public virtual int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._indexOf14046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._indexOf14046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf14047;
		public virtual int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._indexOf14047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._indexOf14047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length14048;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._length14048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._length14048);
		}
		internal static global::MonoJavaBridge.MethodId _charAt14049;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._charAt14049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._charAt14049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt14050;
		public virtual int codePointAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointAt14050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointAt14050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore14051;
		public virtual int codePointBefore(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointBefore14051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointBefore14051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount14052;
		public virtual int codePointCount(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointCount14052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointCount14052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints14053;
		public virtual int offsetByCodePoints(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._offsetByCodePoints14053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._offsetByCodePoints14053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars14054;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._getChars14054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._getChars14054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf14055;
		public virtual int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._lastIndexOf14055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._lastIndexOf14055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf14056;
		public virtual int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._lastIndexOf14056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._lastIndexOf14056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring14057;
		public virtual global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._substring14057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._substring14057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring14058;
		public virtual global::java.lang.String substring(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._substring14058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._substring14058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence14059;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._subSequence14059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._subSequence14059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace14060;
		public virtual global::java.lang.AbstractStringBuilder replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._replace14060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._replace14060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize14061;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._trimToSize14061);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._trimToSize14061);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity14062;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._ensureCapacity14062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._ensureCapacity14062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity14063;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._capacity14063);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._capacity14063);
		}
		internal static global::MonoJavaBridge.MethodId _setLength14064;
		public virtual void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._setLength14064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._setLength14064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt14065;
		public virtual void setCharAt(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._setCharAt14065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._setCharAt14065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint14066;
		public virtual global::java.lang.AbstractStringBuilder appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._appendCodePoint14066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._appendCodePoint14066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete14067;
		public virtual global::java.lang.AbstractStringBuilder delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._delete14067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._delete14067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt14068;
		public virtual global::java.lang.AbstractStringBuilder deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._deleteCharAt14068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._deleteCharAt14068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14069;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14070;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14071;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14072;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14073;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14074;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14075;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14076;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14077;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert14078;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert14079;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert14080;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert14080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert14080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse14081;
		public virtual global::java.lang.AbstractStringBuilder reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._reverse14081)) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._reverse14081)) as java.lang.AbstractStringBuilder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
			global::java.lang.AbstractStringBuilder._toString14032 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._append14033 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(J)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14034 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append14035 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14036 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append14037 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Z)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14038 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "([CII)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14039 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append14040 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14041 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14042 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14043 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "([C)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14044 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(D)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append14045 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(F)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._indexOf14046 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.AbstractStringBuilder._indexOf14047 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.AbstractStringBuilder._length14048 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "length", "()I");
			global::java.lang.AbstractStringBuilder._charAt14049 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.AbstractStringBuilder._codePointAt14050 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointAt", "(I)I");
			global::java.lang.AbstractStringBuilder._codePointBefore14051 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointBefore", "(I)I");
			global::java.lang.AbstractStringBuilder._codePointCount14052 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointCount", "(II)I");
			global::java.lang.AbstractStringBuilder._offsetByCodePoints14053 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.AbstractStringBuilder._getChars14054 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "getChars", "(II[CI)V");
			global::java.lang.AbstractStringBuilder._lastIndexOf14055 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.AbstractStringBuilder._lastIndexOf14056 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.AbstractStringBuilder._substring14057 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._substring14058 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._subSequence14059 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.AbstractStringBuilder._replace14060 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._trimToSize14061 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "trimToSize", "()V");
			global::java.lang.AbstractStringBuilder._ensureCapacity14062 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "ensureCapacity", "(I)V");
			global::java.lang.AbstractStringBuilder._capacity14063 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "capacity", "()I");
			global::java.lang.AbstractStringBuilder._setLength14064 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "setLength", "(I)V");
			global::java.lang.AbstractStringBuilder._setCharAt14065 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "setCharAt", "(IC)V");
			global::java.lang.AbstractStringBuilder._appendCodePoint14066 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._delete14067 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "delete", "(II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._deleteCharAt14068 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14069 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IC)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14070 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14071 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IJ)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14072 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IF)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14073 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ID)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14074 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14075 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14076 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14077 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[C)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14078 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14079 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert14080 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IZ)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._reverse14081 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "reverse", "()Ljava/lang/AbstractStringBuilder;");
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
		internal static global::MonoJavaBridge.MethodId _toString14082;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder_._toString14082)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder_.staticClass, global::java.lang.AbstractStringBuilder_._toString14082)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
			global::java.lang.AbstractStringBuilder_._toString14082 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder_.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
