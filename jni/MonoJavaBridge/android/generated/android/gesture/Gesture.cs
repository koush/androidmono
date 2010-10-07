namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Gesture : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Gesture()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.Gesture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.gesture.Gesture(@__env);
			}
		}
		protected Gesture(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone2764;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._clone2764));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._clone2764));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLength2765;
		public virtual float getLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.gesture.Gesture._getLength2765);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getLength2765);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2766;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.Gesture._writeToParcel2766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._writeToParcel2766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2767;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.Gesture._describeContents2767);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._describeContents2767);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrokes2768;
		public virtual global::java.util.ArrayList getStrokes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._getStrokes2768));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokes2768));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrokesCount2769;
		public virtual int getStrokesCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.Gesture._getStrokesCount2769);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokesCount2769);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addStroke2770;
		public virtual void addStroke(android.gesture.GestureStroke arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.Gesture._addStroke2770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._addStroke2770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoundingBox2771;
		public virtual global::android.graphics.RectF getBoundingBox() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._getBoundingBox2771));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getBoundingBox2771));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toPath2772;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._toPath2772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toPath2773;
		public virtual global::android.graphics.Path toPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._toPath2773));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2773));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toPath2774;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._toPath2774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toPath2775;
		public virtual global::android.graphics.Path toPath(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._toPath2775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getID2776;
		public virtual long getID() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.gesture.Gesture._getID2776);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getID2776);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toBitmap2777;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._toBitmap2777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap2777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toBitmap2778;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.Gesture._toBitmap2778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap2778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Gesture2779;
		public Gesture()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.gesture.Gesture.staticClass, global::android.gesture.Gesture._Gesture2779, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2780;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.gesture.Gesture.staticClass = @__class;
			global::android.gesture.Gesture._clone2764 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.Gesture._getLength2765 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getLength", "()F");
			global::android.gesture.Gesture._writeToParcel2766 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.gesture.Gesture._describeContents2767 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "describeContents", "()I");
			global::android.gesture.Gesture._getStrokes2768 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getStrokes", "()Ljava/util/ArrayList;");
			global::android.gesture.Gesture._getStrokesCount2769 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getStrokesCount", "()I");
			global::android.gesture.Gesture._addStroke2770 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "addStroke", "(Landroid/gesture/GestureStroke;)V");
			global::android.gesture.Gesture._getBoundingBox2771 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getBoundingBox", "()Landroid/graphics/RectF;");
			global::android.gesture.Gesture._toPath2772 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath2773 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "()Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath2774 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath2775 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "(IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._getID2776 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getID", "()J");
			global::android.gesture.Gesture._toBitmap2777 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._toBitmap2778 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._Gesture2779 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "<init>", "()V");
		}
	}
}
