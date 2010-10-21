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
		internal static global::MonoJavaBridge.MethodId _clone4846;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._clone4846)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._clone4846)) as java.lang.Object;
		}
		public new float Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength4847;
		public virtual float getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.Gesture._getLength4847);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getLength4847);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4848;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.Gesture._writeToParcel4848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._writeToParcel4848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4849;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.Gesture._describeContents4849);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._describeContents4849);
		}
		public new global::java.util.ArrayList Strokes
		{
			get
			{
				return getStrokes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokes4850;
		public virtual global::java.util.ArrayList getStrokes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._getStrokes4850)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokes4850)) as java.util.ArrayList;
		}
		public new int StrokesCount
		{
			get
			{
				return getStrokesCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokesCount4851;
		public virtual int getStrokesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.Gesture._getStrokesCount4851);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getStrokesCount4851);
		}
		internal static global::MonoJavaBridge.MethodId _addStroke4852;
		public virtual void addStroke(android.gesture.GestureStroke arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.Gesture._addStroke4852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._addStroke4852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.RectF BoundingBox
		{
			get
			{
				return getBoundingBox();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBoundingBox4853;
		public virtual global::android.graphics.RectF getBoundingBox() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._getBoundingBox4853)) as android.graphics.RectF;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getBoundingBox4853)) as android.graphics.RectF;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4854;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4855;
		public virtual global::android.graphics.Path toPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4855)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4855)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4856;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4857;
		public virtual global::android.graphics.Path toPath(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toPath4857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toPath4857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Path;
		}
		public new long ID
		{
			get
			{
				return getID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getID4858;
		public virtual long getID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.gesture.Gesture._getID4858);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._getID4858);
		}
		internal static global::MonoJavaBridge.MethodId _toBitmap4859;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toBitmap4859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap4859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _toBitmap4860;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Gesture._toBitmap4860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Gesture.staticClass, global::android.gesture.Gesture._toBitmap4860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _Gesture4861;
		public Gesture()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.Gesture.staticClass, global::android.gesture.Gesture._Gesture4861);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4862;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.gesture.Gesture.staticClass, _CREATOR4862)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Gesture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Gesture"));
			global::android.gesture.Gesture._clone4846 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.Gesture._getLength4847 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getLength", "()F");
			global::android.gesture.Gesture._writeToParcel4848 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.gesture.Gesture._describeContents4849 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "describeContents", "()I");
			global::android.gesture.Gesture._getStrokes4850 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getStrokes", "()Ljava/util/ArrayList;");
			global::android.gesture.Gesture._getStrokesCount4851 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getStrokesCount", "()I");
			global::android.gesture.Gesture._addStroke4852 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "addStroke", "(Landroid/gesture/GestureStroke;)V");
			global::android.gesture.Gesture._getBoundingBox4853 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getBoundingBox", "()Landroid/graphics/RectF;");
			global::android.gesture.Gesture._toPath4854 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath4855 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "()Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath4856 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.Gesture._toPath4857 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toPath", "(IIII)Landroid/graphics/Path;");
			global::android.gesture.Gesture._getID4858 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "getID", "()J");
			global::android.gesture.Gesture._toBitmap4859 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._toBitmap4860 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIIII)Landroid/graphics/Bitmap;");
			global::android.gesture.Gesture._Gesture4861 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "<init>", "()V");
			global::android.gesture.Gesture._CREATOR4862 = @__env.GetStaticFieldIDNoThrow(global::android.gesture.Gesture.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
