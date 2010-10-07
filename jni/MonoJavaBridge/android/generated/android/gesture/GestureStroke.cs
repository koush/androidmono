namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GestureStroke : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GestureStroke()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureStroke), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.gesture.GestureStroke(@__env);
			}
		}
		protected GestureStroke(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone2875;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStroke._clone2875));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._clone2875));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPath2876;
		public virtual global::android.graphics.Path getPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStroke._getPath2876));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._getPath2876));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toPath2877;
		public virtual global::android.graphics.Path toPath(float arg0, float arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStroke._toPath2877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._toPath2877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearPath2878;
		public virtual void clearPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureStroke._clearPath2878);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._clearPath2878);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeOrientedBoundingBox2879;
		public virtual global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.OrientedBoundingBox>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureStroke._computeOrientedBoundingBox2879));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.OrientedBoundingBox>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._computeOrientedBoundingBox2879));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureStroke2880;
		public GestureStroke(java.util.ArrayList arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._GestureStroke2880, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _boundingBox2881;
		public global::android.graphics.RectF boundingBox
		{
			get
			{
				return default(global::android.graphics.RectF);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _length2882;
		public float length
		{
			get
			{
				return default(float);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _points2883;
		public float[] points
		{
			get
			{
				return default(float[]);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.gesture.GestureStroke.staticClass = @__class;
			global::android.gesture.GestureStroke._clone2875 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.GestureStroke._getPath2876 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "getPath", "()Landroid/graphics/Path;");
			global::android.gesture.GestureStroke._toPath2877 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "toPath", "(FFI)Landroid/graphics/Path;");
			global::android.gesture.GestureStroke._clearPath2878 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "clearPath", "()V");
			global::android.gesture.GestureStroke._computeOrientedBoundingBox2879 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureStroke._GestureStroke2880 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "<init>", "(Ljava/util/ArrayList;)V");
		}
	}
}
