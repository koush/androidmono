namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Gesture : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Gesture() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.Gesture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getLength2382; 
		public virtual float getLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return @__env.CallFloatMethod(this, _getLength2382); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.Gesture.staticClass, _getLength2382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2383; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				@__env.CallVoidMethod(this, _writeToParcel2383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.Gesture.staticClass, _writeToParcel2383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2384; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return @__env.CallIntMethod(this, _describeContents2384); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.Gesture.staticClass, _describeContents2384); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokes2385; 
		public virtual java.util.ArrayList getStrokes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getStrokes2385)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _getStrokes2385)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokesCount2386; 
		public virtual int getStrokesCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return @__env.CallIntMethod(this, _getStrokesCount2386); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.Gesture.staticClass, _getStrokesCount2386); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addStroke2387; 
		public virtual void addStroke(android.gesture.GestureStroke arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				@__env.CallVoidMethod(this, _addStroke2387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.Gesture.staticClass, _addStroke2387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoundingBox2388; 
		public virtual android.graphics.RectF getBoundingBox() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallObjectMethodPtr(this, _getBoundingBox2388)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _getBoundingBox2388)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toPath2389; 
		public virtual android.graphics.Path toPath(android.graphics.Path arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _toPath2389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _toPath2389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toPath2390; 
		public virtual android.graphics.Path toPath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _toPath2390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _toPath2390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toPath2391; 
		public virtual android.graphics.Path toPath(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _toPath2391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _toPath2391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toPath2392; 
		public virtual android.graphics.Path toPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _toPath2392)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _toPath2392)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getID2393; 
		public virtual long getID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return @__env.CallLongMethod(this, _getID2393); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.gesture.Gesture.staticClass, _getID2393); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toBitmap2394; 
		public virtual android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _toBitmap2394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _toBitmap2394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toBitmap2395; 
		public virtual android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Gesture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _toBitmap2395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Gesture.staticClass, _toBitmap2395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Gesture2396; 
		public Gesture()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.Gesture.staticClass, _Gesture2396, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2397; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.Gesture.staticClass = @__class; 
			global::android.gesture.Gesture._getLength2382 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getLength", "()F"); 
			global::android.gesture.Gesture._writeToParcel2383 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.gesture.Gesture._describeContents2384 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "describeContents", "()I"); 
			global::android.gesture.Gesture._getStrokes2385 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getStrokes", "()Ljava/util/ArrayList;"); 
			global::android.gesture.Gesture._getStrokesCount2386 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getStrokesCount", "()I"); 
			global::android.gesture.Gesture._addStroke2387 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "addStroke", "(Landroid/gesture/GestureStroke;)V"); 
			global::android.gesture.Gesture._getBoundingBox2388 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getBoundingBox", "()Landroid/graphics/RectF;"); 
			global::android.gesture.Gesture._toPath2389 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;"); 
			global::android.gesture.Gesture._toPath2390 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;"); 
			global::android.gesture.Gesture._toPath2391 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "(IIII)Landroid/graphics/Path;"); 
			global::android.gesture.Gesture._toPath2392 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toPath", "()Landroid/graphics/Path;"); 
			global::android.gesture.Gesture._getID2393 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "getID", "()J"); 
			global::android.gesture.Gesture._toBitmap2394 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIIII)Landroid/graphics/Bitmap;"); 
			global::android.gesture.Gesture._toBitmap2395 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "toBitmap", "(IIII)Landroid/graphics/Bitmap;"); 
			global::android.gesture.Gesture._Gesture2396 = @__env.GetMethodID(global::android.gesture.Gesture.staticClass, "<init>", "()V"); 
		} 
	} 
} 
