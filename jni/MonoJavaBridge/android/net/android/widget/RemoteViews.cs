namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RemoteViews : java.lang.Object, android.os.Parcelable, android.view.LayoutInflater.Filter
	{ 
		internal static global::java.lang.Class staticClass; 
		static RemoteViews() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RemoteViews), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.RemoteViews(@__env); 
			} 
		} 
		protected RemoteViews(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class ActionException : java.lang.RuntimeException
		{ 
			internal static global::java.lang.Class staticClass; 
			static ActionException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RemoteViews.ActionException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.RemoteViews.ActionException(@__env); 
				} 
			} 
			protected ActionException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActionException9915; 
			public ActionException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, _ActionException9915, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActionException9916; 
			public ActionException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, _ActionException9916, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.RemoteViews.ActionException.staticClass = @__class; 
				global::android.widget.RemoteViews.ActionException._ActionException9915 = @__env.GetMethodID(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V"); 
				global::android.widget.RemoteViews.ActionException._ActionException9916 = @__env.GetMethodID(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface RemoteView : java.lang.annotation.Annotation
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackage9917; 
		public virtual java.lang.String getPackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackage9917)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RemoteViews.staticClass, _getPackage9917)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBoolean9918; 
		public virtual void setBoolean(int arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setBoolean9918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setBoolean9918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setByte9919; 
		public virtual void setByte(int arg0, java.lang.String arg1, byte arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setByte9919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setByte9919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChar9920; 
		public virtual void setChar(int arg0, java.lang.String arg1, char arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setChar9920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setChar9920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShort9921; 
		public virtual void setShort(int arg0, java.lang.String arg1, short arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setShort9921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setShort9921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInt9922; 
		public virtual void setInt(int arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setInt9922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setInt9922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLong9923; 
		public virtual void setLong(int arg0, java.lang.String arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setLong9923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setLong9923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFloat9924; 
		public virtual void setFloat(int arg0, java.lang.String arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setFloat9924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setFloat9924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDouble9925; 
		public virtual void setDouble(int arg0, java.lang.String arg1, double arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setDouble9925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setDouble9925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9926; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _writeToParcel9926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _writeToParcel9926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9927; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				return @__env.CallIntMethod(this, _describeContents9927); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.RemoteViews.staticClass, _describeContents9927); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9928; 
		public virtual void addView(int arg0, android.widget.RemoteViews arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _addView9928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _addView9928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap9929; 
		public virtual void setBitmap(int arg0, java.lang.String arg1, android.graphics.Bitmap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setBitmap9929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setBitmap9929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews9930; 
		public virtual void removeAllViews(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _removeAllViews9930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _removeAllViews9930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor9931; 
		public virtual void setTextColor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setTextColor9931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setTextColor9931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutId9932; 
		public virtual int getLayoutId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				return @__env.CallIntMethod(this, _getLayoutId9932); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.RemoteViews.staticClass, _getLayoutId9932); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewVisibility9933; 
		public virtual void setViewVisibility(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setViewVisibility9933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setViewVisibility9933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextViewText9934; 
		public virtual void setTextViewText(int arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setTextViewText9934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setTextViewText9934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageViewResource9935; 
		public virtual void setImageViewResource(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setImageViewResource9935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setImageViewResource9935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageViewUri9936; 
		public virtual void setImageViewUri(int arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setImageViewUri9936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setImageViewUri9936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageViewBitmap9937; 
		public virtual void setImageViewBitmap(int arg0, android.graphics.Bitmap arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setImageViewBitmap9937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setImageViewBitmap9937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChronometer9938; 
		public virtual void setChronometer(int arg0, long arg1, java.lang.String arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setChronometer9938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setChronometer9938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBar9939; 
		public virtual void setProgressBar(int arg0, int arg1, int arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setProgressBar9939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setProgressBar9939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickPendingIntent9940; 
		public virtual void setOnClickPendingIntent(int arg0, android.app.PendingIntent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setOnClickPendingIntent9940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setOnClickPendingIntent9940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setString9941; 
		public virtual void setString(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setString9941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setString9941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCharSequence9942; 
		public virtual void setCharSequence(int arg0, java.lang.String arg1, java.lang.CharSequence arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setCharSequence9942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setCharSequence9942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUri9943; 
		public virtual void setUri(int arg0, java.lang.String arg1, android.net.Uri arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _setUri9943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _setUri9943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _apply9944; 
		public virtual android.view.View apply(android.content.Context arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _apply9944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RemoteViews.staticClass, _apply9944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reapply9945; 
		public virtual void reapply(android.content.Context arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				@__env.CallVoidMethod(this, _reapply9945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RemoteViews.staticClass, _reapply9945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLoadClass9946; 
		public virtual bool onLoadClass(java.lang.Class arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RemoteViews)) 
				return @__env.CallBooleanMethod(this, _onLoadClass9946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RemoteViews.staticClass, _onLoadClass9946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RemoteViews9947; 
		public RemoteViews(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RemoteViews.staticClass, _RemoteViews9947, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RemoteViews9948; 
		public RemoteViews(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RemoteViews.staticClass, _RemoteViews9948, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9949; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.RemoteViews.staticClass = @__class; 
			global::android.widget.RemoteViews._getPackage9917 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "getPackage", "()Ljava/lang/String;"); 
			global::android.widget.RemoteViews._setBoolean9918 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setBoolean", "(ILjava/lang/String;Z)V"); 
			global::android.widget.RemoteViews._setByte9919 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setByte", "(ILjava/lang/String;B)V"); 
			global::android.widget.RemoteViews._setChar9920 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setChar", "(ILjava/lang/String;C)V"); 
			global::android.widget.RemoteViews._setShort9921 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setShort", "(ILjava/lang/String;S)V"); 
			global::android.widget.RemoteViews._setInt9922 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setInt", "(ILjava/lang/String;I)V"); 
			global::android.widget.RemoteViews._setLong9923 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setLong", "(ILjava/lang/String;J)V"); 
			global::android.widget.RemoteViews._setFloat9924 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setFloat", "(ILjava/lang/String;F)V"); 
			global::android.widget.RemoteViews._setDouble9925 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setDouble", "(ILjava/lang/String;D)V"); 
			global::android.widget.RemoteViews._writeToParcel9926 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.widget.RemoteViews._describeContents9927 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "describeContents", "()I"); 
			global::android.widget.RemoteViews._addView9928 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "addView", "(ILandroid/widget/RemoteViews;)V"); 
			global::android.widget.RemoteViews._setBitmap9929 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V"); 
			global::android.widget.RemoteViews._removeAllViews9930 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "removeAllViews", "(I)V"); 
			global::android.widget.RemoteViews._setTextColor9931 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setTextColor", "(II)V"); 
			global::android.widget.RemoteViews._getLayoutId9932 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "getLayoutId", "()I"); 
			global::android.widget.RemoteViews._setViewVisibility9933 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setViewVisibility", "(II)V"); 
			global::android.widget.RemoteViews._setTextViewText9934 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setTextViewText", "(ILjava/lang/CharSequence;)V"); 
			global::android.widget.RemoteViews._setImageViewResource9935 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setImageViewResource", "(II)V"); 
			global::android.widget.RemoteViews._setImageViewUri9936 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setImageViewUri", "(ILandroid/net/Uri;)V"); 
			global::android.widget.RemoteViews._setImageViewBitmap9937 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V"); 
			global::android.widget.RemoteViews._setChronometer9938 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setChronometer", "(IJLjava/lang/String;Z)V"); 
			global::android.widget.RemoteViews._setProgressBar9939 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setProgressBar", "(IIIZ)V"); 
			global::android.widget.RemoteViews._setOnClickPendingIntent9940 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V"); 
			global::android.widget.RemoteViews._setString9941 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setString", "(ILjava/lang/String;Ljava/lang/String;)V"); 
			global::android.widget.RemoteViews._setCharSequence9942 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V"); 
			global::android.widget.RemoteViews._setUri9943 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setUri", "(ILjava/lang/String;Landroid/net/Uri;)V"); 
			global::android.widget.RemoteViews._apply9944 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.RemoteViews._reapply9945 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "reapply", "(Landroid/content/Context;Landroid/view/View;)V"); 
			global::android.widget.RemoteViews._onLoadClass9946 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z"); 
			global::android.widget.RemoteViews._RemoteViews9947 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
			global::android.widget.RemoteViews._RemoteViews9948 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
