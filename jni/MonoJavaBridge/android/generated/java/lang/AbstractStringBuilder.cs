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
		internal static global::MonoJavaBridge.MethodId _toString12733;
		public abstract new global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _append12734;
		public virtual global::java.lang.AbstractStringBuilder append(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12735;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append12736;
		public virtual global::java.lang.AbstractStringBuilder append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12737;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12738;
		public virtual global::java.lang.AbstractStringBuilder append(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12739;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12740;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12741;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12742;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12743;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12744;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12745;
		public virtual global::java.lang.AbstractStringBuilder append(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append12746;
		public virtual global::java.lang.AbstractStringBuilder append(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._append12746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._append12746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf12747;
		public virtual int indexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._indexOf12747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._indexOf12747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf12748;
		public virtual int indexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._indexOf12748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._indexOf12748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length12749;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._length12749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._length12749);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12750;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._charAt12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._charAt12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt12751;
		public virtual int codePointAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointAt12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointAt12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore12752;
		public virtual int codePointBefore(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointBefore12752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointBefore12752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount12753;
		public virtual int codePointCount(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._codePointCount12753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._codePointCount12753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints12754;
		public virtual int offsetByCodePoints(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._offsetByCodePoints12754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._offsetByCodePoints12754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars12755;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._getChars12755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._getChars12755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf12756;
		public virtual int lastIndexOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._lastIndexOf12756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._lastIndexOf12756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf12757;
		public virtual int lastIndexOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._lastIndexOf12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._lastIndexOf12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring12758;
		public virtual global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._substring12758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._substring12758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring12759;
		public virtual global::java.lang.String substring(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._substring12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._substring12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12760;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._subSequence12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._subSequence12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace12761;
		public virtual global::java.lang.AbstractStringBuilder replace(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._replace12761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._replace12761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize12762;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._trimToSize12762);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._trimToSize12762);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity12763;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._ensureCapacity12763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._ensureCapacity12763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity12764;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._capacity12764);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._capacity12764);
		}
		internal static global::MonoJavaBridge.MethodId _setLength12765;
		public virtual void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._setLength12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._setLength12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt12766;
		public virtual void setCharAt(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._setCharAt12766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._setCharAt12766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint12767;
		public virtual global::java.lang.AbstractStringBuilder appendCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._appendCodePoint12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._appendCodePoint12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete12768;
		public virtual global::java.lang.AbstractStringBuilder delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._delete12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._delete12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt12769;
		public virtual global::java.lang.AbstractStringBuilder deleteCharAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._deleteCharAt12769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._deleteCharAt12769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12770;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12771;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12772;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12773;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12774;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12775;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12776;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12777;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12778;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert12779;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert12780;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert12781;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._insert12781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._insert12781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse12782;
		public virtual global::java.lang.AbstractStringBuilder reverse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder._reverse12782)) as java.lang.AbstractStringBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder.staticClass, global::java.lang.AbstractStringBuilder._reverse12782)) as java.lang.AbstractStringBuilder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
			global::java.lang.AbstractStringBuilder._toString12733 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._append12734 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(J)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12735 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append12736 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12737 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append12738 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Z)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12739 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "([CII)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12740 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.lang.AbstractStringBuilder._append12741 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12742 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12743 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12744 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "([C)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12745 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(D)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._append12746 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "append", "(F)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._indexOf12747 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
			global::java.lang.AbstractStringBuilder._indexOf12748 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
			global::java.lang.AbstractStringBuilder._length12749 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "length", "()I");
			global::java.lang.AbstractStringBuilder._charAt12750 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "charAt", "(I)C");
			global::java.lang.AbstractStringBuilder._codePointAt12751 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointAt", "(I)I");
			global::java.lang.AbstractStringBuilder._codePointBefore12752 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointBefore", "(I)I");
			global::java.lang.AbstractStringBuilder._codePointCount12753 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "codePointCount", "(II)I");
			global::java.lang.AbstractStringBuilder._offsetByCodePoints12754 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "offsetByCodePoints", "(II)I");
			global::java.lang.AbstractStringBuilder._getChars12755 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "getChars", "(II[CI)V");
			global::java.lang.AbstractStringBuilder._lastIndexOf12756 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
			global::java.lang.AbstractStringBuilder._lastIndexOf12757 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
			global::java.lang.AbstractStringBuilder._substring12758 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(II)Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._substring12759 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(I)Ljava/lang/String;");
			global::java.lang.AbstractStringBuilder._subSequence12760 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.lang.AbstractStringBuilder._replace12761 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._trimToSize12762 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "trimToSize", "()V");
			global::java.lang.AbstractStringBuilder._ensureCapacity12763 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "ensureCapacity", "(I)V");
			global::java.lang.AbstractStringBuilder._capacity12764 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "capacity", "()I");
			global::java.lang.AbstractStringBuilder._setLength12765 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "setLength", "(I)V");
			global::java.lang.AbstractStringBuilder._setCharAt12766 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "setCharAt", "(IC)V");
			global::java.lang.AbstractStringBuilder._appendCodePoint12767 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._delete12768 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "delete", "(II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._deleteCharAt12769 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12770 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IC)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12771 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12772 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IJ)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12773 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IF)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12774 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ID)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12775 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12776 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12777 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12778 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[C)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12779 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12780 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._insert12781 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IZ)Ljava/lang/AbstractStringBuilder;");
			global::java.lang.AbstractStringBuilder._reverse12782 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder.staticClass, "reverse", "()Ljava/lang/AbstractStringBuilder;");
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
		internal static global::MonoJavaBridge.MethodId _toString12783;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder_._toString12783)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.AbstractStringBuilder_.staticClass, global::java.lang.AbstractStringBuilder_._toString12783)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
			global::java.lang.AbstractStringBuilder_._toString12783 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractStringBuilder_.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
