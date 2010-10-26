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
		internal static global::MonoJavaBridge.MethodId _clone4864;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._clone4864)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._clone4864)) as java.lang.Object;
		}
		public new float Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength4865;
		public virtual float getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.Gesture._getLength4865);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getLength4865);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4866;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.Gesture._writeToParcel4866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._writeToParcel4866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4867;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.Gesture._describeContents4867);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._describeContents4867);
		}
		public new global::java.util.ArrayList Strokes
		{
			get
			{
				return getStrokes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokes4868;
		public virtual global::java.util.ArrayList getStrokes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._getStrokes4868)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokes4868)) as java.util.ArrayList;
		}
		public new int StrokesCount
		{
			get
			{
				return getStrokesCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokesCount4869;
		public virtual int getStrokesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.Gesture._getStrokesCount4869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokesCount4869);
		}
		internal static global::MonoJavaBridge.MethodId _addStroke4870;
		public virtual void addStroke(android.gesture.GestureStroke arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.Gesture._addStroke4870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._addStroke4870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.RectF BoundingBox
		{
			get
			{
				return getBoundingBox();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBoundingBox4871;
		public virtual global::android.graphics.RectF getBoundingBox() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._getBoundingBox4871)) as android.graphics.RectF;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getBoundingBox4871)) as android.graphics.RectF;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4872;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4873;
		public virtual global::android.graphics.Path toPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4873)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4873)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4874;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4875;
		public virtual global::android.graphics.Path toPath(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Path;
		}
		public new long ID
		{
			get
			{
				return getID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getID4876;
		public virtual long getID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.gesture.Gesture._getID4876);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getID4876);
		}
		internal static global::MonoJavaBridge.MethodId _toBitmap4877;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toBitmap4877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap4877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _toBitmap4878;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toBitmap4878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap4878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _Gesture4879;
		public Gesture()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.Gesture.staticClass, global::android.gesture.Gesture._Gesture4879);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4880;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.gesture.Gesture.staticClass, _CREATOR4880)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Gesture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Gesture"));
			global::android.gesture.Gesture._clone4864 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.Gesture._getLength4865 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getLength", "()F");
			global::android.gesture.Gesture._writeToParcel4866 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.gesture.Gesture._describeContents4867 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "describeContents", "()I");
			global::android.gesture.Gesture._getStrokes4868 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getStrokes", "()Ljava/util/ArrayList;");
			global::android.gesture.Gesture._getStrokesCount4869 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getStrokesCount", "()I");
			global::android.gesture.Gesture._addStroke4870 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "addStroke", "(Landroid/gesture/GestureStroke;)V");
			global::android.gesture.Gesture._getBoundingBox4871 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getBoundingBox", "()Landroid/graphics/RectF;");
			global::android.gesture.Gesture._toPath4872 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath4873 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "()Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath4874 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath4875 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._getID4876 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getID", "()J");
			global::android.gesture.Gesture._toBitmap4877 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._toBitmap4878 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._Gesture4879 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "<init>", "()V");
			global::android.gesture.Gesture._CREATOR4880 = @__env.GetStaticFieldIDNoThrow(global::android.gesture.Gesture.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
