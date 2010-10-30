namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Point : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Point(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals5619;
		public virtual bool equals(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._equals5619.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._equals5619 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "equals", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals5619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals5620;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._equals5620.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._equals5620 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals5620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5621;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._toString5621.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._toString5621 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._toString5621) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode5622;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._hashCode5622.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._hashCode5622 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._hashCode5622);
		}
		internal static global::MonoJavaBridge.MethodId _offset5623;
		public virtual void offset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._offset5623.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._offset5623 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "offset", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._offset5623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5624;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._set5624.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._set5624 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "set", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._set5624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _negate5625;
		public virtual void negate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._negate5625.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._negate5625 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "negate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._negate5625);
		}
		internal static global::MonoJavaBridge.MethodId _Point5626;
		public Point(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._Point5626.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._Point5626 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point5626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Point5627;
		public Point(android.graphics.Point arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._Point5627.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._Point5627 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point5627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Point5628;
		public Point() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._Point5628.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._Point5628 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point5628);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x5629;
		public int x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _x5629);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y5630;
		public int y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _y5630);
			}
			set
			{
			}
		}
		static Point()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Point.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Point"));
			global::android.graphics.Point._x5629 = @__env.GetFieldIDNoThrow(global::android.graphics.Point.staticClass, "x", "I");
			global::android.graphics.Point._y5630 = @__env.GetFieldIDNoThrow(global::android.graphics.Point.staticClass, "y", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
