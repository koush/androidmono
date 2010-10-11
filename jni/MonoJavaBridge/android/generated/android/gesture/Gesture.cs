namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Gesture : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Gesture()
		{
			InitJNI();
		}
		protected Gesture(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone2936;
		public virtual new global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._clone2936)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._clone2936)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getLength2937;
		public virtual float getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.Gesture._getLength2937);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getLength2937);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2938;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.Gesture._writeToParcel2938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._writeToParcel2938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2939;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.Gesture._describeContents2939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._describeContents2939);
		}
		internal static global::MonoJavaBridge.MethodId _getStrokes2940;
		public virtual global::java.util.ArrayList getStrokes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._getStrokes2940)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokes2940)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStrokesCount2941;
		public virtual int getStrokesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.Gesture._getStrokesCount2941);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokesCount2941);
		}
		internal static global::MonoJavaBridge.MethodId _addStroke2942;
		public virtual void addStroke(android.gesture.GestureStroke arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.Gesture._addStroke2942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._addStroke2942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoundingBox2943;
		public virtual global::android.graphics.RectF getBoundingBox() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._getBoundingBox2943)) as android.graphics.RectF;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getBoundingBox2943)) as android.graphics.RectF;
		}
		internal static global::MonoJavaBridge.MethodId _toPath2944;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath2944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath2945;
		public virtual global::android.graphics.Path toPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath2945)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2945)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath2946;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath2946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath2947;
		public virtual global::android.graphics.Path toPath(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath2947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath2947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getID2948;
		public virtual long getID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.gesture.Gesture._getID2948);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getID2948);
		}
		internal static global::MonoJavaBridge.MethodId _toBitmap2949;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toBitmap2949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap2949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _toBitmap2950;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toBitmap2950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap2950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _Gesture2951;
		public Gesture()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.Gesture.staticClass, global::android.gesture.Gesture._Gesture2951);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2952;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Gesture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Gesture"));
			global::android.gesture.Gesture._clone2936 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.Gesture._getLength2937 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getLength", "()F");
			global::android.gesture.Gesture._writeToParcel2938 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.gesture.Gesture._describeContents2939 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "describeContents", "()I");
			global::android.gesture.Gesture._getStrokes2940 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getStrokes", "()Ljava/util/ArrayList;");
			global::android.gesture.Gesture._getStrokesCount2941 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getStrokesCount", "()I");
			global::android.gesture.Gesture._addStroke2942 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "addStroke", "(Landroid/gesture/GestureStroke;)V");
			global::android.gesture.Gesture._getBoundingBox2943 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getBoundingBox", "()Landroid/graphics/RectF;");
			global::android.gesture.Gesture._toPath2944 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath2945 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "()Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath2946 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath2947 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._getID2948 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getID", "()J");
			global::android.gesture.Gesture._toBitmap2949 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._toBitmap2950 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._Gesture2951 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "<init>", "()V");
		}
	}
}
