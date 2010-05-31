namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RemoteViews : java.lang.Object, android.os.Parcelable, android.view.LayoutInflater.Filter
	{
		internal static global::java.lang.Class staticClass;
		static RemoteViews()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RemoteViews), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RemoteViews.ActionException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _ActionException10687;
			public ActionException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException10687, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ActionException10688;
			public ActionException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException10688, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.RemoteViews.ActionException.staticClass = @__class;
				global::android.widget.RemoteViews.ActionException._ActionException10687 = @__env.GetMethodID(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::android.widget.RemoteViews.ActionException._ActionException10688 = @__env.GetMethodID(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface RemoteView : java.lang.annotation.Annotation
		{
		}

		public partial class RemoteView_
		{
			public static global::java.lang.Class _class
			{
				get { return __RemoteView.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __RemoteView : java.lang.Object, RemoteView
		{
			internal static global::java.lang.Class staticClass;
			static __RemoteView()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RemoteViews.__RemoteView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.RemoteViews.__RemoteView(@__env);
				}
			}
			internal __RemoteView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode10689;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.RemoteViews.__RemoteView._hashCode10689);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.RemoteViews.__RemoteView.staticClass, global::android.widget.RemoteViews.__RemoteView._hashCode10689);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals10690;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.RemoteViews.__RemoteView._equals10690, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RemoteViews.__RemoteView.staticClass, global::android.widget.RemoteViews.__RemoteView._equals10690, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString10691;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RemoteViews.__RemoteView._toString10691));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RemoteViews.__RemoteView.staticClass, global::android.widget.RemoteViews.__RemoteView._toString10691));
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType10692;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RemoteViews.__RemoteView._annotationType10692));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RemoteViews.__RemoteView.staticClass, global::android.widget.RemoteViews.__RemoteView._annotationType10692));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.RemoteViews.__RemoteView.staticClass = @__class;
				global::android.widget.RemoteViews.__RemoteView._hashCode10689 = @__env.GetMethodID(global::android.widget.RemoteViews.__RemoteView.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.widget.RemoteViews.__RemoteView._equals10690 = @__env.GetMethodID(global::android.widget.RemoteViews.__RemoteView.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.widget.RemoteViews.__RemoteView._toString10691 = @__env.GetMethodID(global::android.widget.RemoteViews.__RemoteView.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.widget.RemoteViews.__RemoteView._annotationType10692 = @__env.GetMethodID(global::android.widget.RemoteViews.__RemoteView.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackage10693;
		public virtual global::java.lang.String getPackage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RemoteViews._getPackage10693));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._getPackage10693));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBoolean10694;
		public virtual void setBoolean(int arg0, java.lang.String arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setBoolean10694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBoolean10694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setByte10695;
		public virtual void setByte(int arg0, java.lang.String arg1, byte arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setByte10695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setByte10695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChar10696;
		public virtual void setChar(int arg0, java.lang.String arg1, char arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setChar10696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setChar10696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShort10697;
		public virtual void setShort(int arg0, java.lang.String arg1, short arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setShort10697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setShort10697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInt10698;
		public virtual void setInt(int arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setInt10698, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setInt10698, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLong10699;
		public virtual void setLong(int arg0, java.lang.String arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setLong10699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setLong10699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFloat10700;
		public virtual void setFloat(int arg0, java.lang.String arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setFloat10700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setFloat10700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDouble10701;
		public virtual void setDouble(int arg0, java.lang.String arg1, double arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setDouble10701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setDouble10701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel10702;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._writeToParcel10702, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._writeToParcel10702, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents10703;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.RemoteViews._describeContents10703);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._describeContents10703);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10704;
		public virtual void addView(int arg0, android.widget.RemoteViews arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._addView10704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._addView10704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap10705;
		public virtual void setBitmap(int arg0, java.lang.String arg1, android.graphics.Bitmap arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setBitmap10705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBitmap10705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews10706;
		public virtual void removeAllViews(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._removeAllViews10706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._removeAllViews10706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor10707;
		public virtual void setTextColor(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setTextColor10707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setTextColor10707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutId10708;
		public virtual int getLayoutId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.RemoteViews._getLayoutId10708);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._getLayoutId10708);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewVisibility10709;
		public virtual void setViewVisibility(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setViewVisibility10709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setViewVisibility10709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextViewText10710;
		public virtual void setTextViewText(int arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setTextViewText10710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setTextViewText10710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		public void setTextViewText(int arg0, string arg1)
		{
			setTextViewText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageViewResource10711;
		public virtual void setImageViewResource(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setImageViewResource10711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewResource10711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageViewUri10712;
		public virtual void setImageViewUri(int arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setImageViewUri10712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewUri10712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageViewBitmap10713;
		public virtual void setImageViewBitmap(int arg0, android.graphics.Bitmap arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setImageViewBitmap10713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewBitmap10713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChronometer10714;
		public virtual void setChronometer(int arg0, long arg1, java.lang.String arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setChronometer10714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setChronometer10714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBar10715;
		public virtual void setProgressBar(int arg0, int arg1, int arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setProgressBar10715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setProgressBar10715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickPendingIntent10716;
		public virtual void setOnClickPendingIntent(int arg0, android.app.PendingIntent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setOnClickPendingIntent10716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setOnClickPendingIntent10716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setString10717;
		public virtual void setString(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setString10717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setString10717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCharSequence10718;
		public virtual void setCharSequence(int arg0, java.lang.String arg1, java.lang.CharSequence arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setCharSequence10718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setCharSequence10718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		public void setCharSequence(int arg0, java.lang.String arg1, string arg2)
		{
			setCharSequence(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUri10719;
		public virtual void setUri(int arg0, java.lang.String arg1, android.net.Uri arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._setUri10719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setUri10719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _apply10720;
		public virtual global::android.view.View apply(android.content.Context arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RemoteViews._apply10720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._apply10720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reapply10721;
		public virtual void reapply(android.content.Context arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RemoteViews._reapply10721, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._reapply10721, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLoadClass10722;
		public virtual bool onLoadClass(java.lang.Class arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.RemoteViews._onLoadClass10722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._onLoadClass10722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RemoteViews10723;
		public RemoteViews(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews10723, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RemoteViews10724;
		public RemoteViews(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews10724, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR10725;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.RemoteViews.staticClass = @__class;
			global::android.widget.RemoteViews._getPackage10693 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "getPackage", "()Ljava/lang/String;");
			global::android.widget.RemoteViews._setBoolean10694 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setBoolean", "(ILjava/lang/String;Z)V");
			global::android.widget.RemoteViews._setByte10695 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setByte", "(ILjava/lang/String;B)V");
			global::android.widget.RemoteViews._setChar10696 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setChar", "(ILjava/lang/String;C)V");
			global::android.widget.RemoteViews._setShort10697 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setShort", "(ILjava/lang/String;S)V");
			global::android.widget.RemoteViews._setInt10698 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setInt", "(ILjava/lang/String;I)V");
			global::android.widget.RemoteViews._setLong10699 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setLong", "(ILjava/lang/String;J)V");
			global::android.widget.RemoteViews._setFloat10700 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setFloat", "(ILjava/lang/String;F)V");
			global::android.widget.RemoteViews._setDouble10701 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setDouble", "(ILjava/lang/String;D)V");
			global::android.widget.RemoteViews._writeToParcel10702 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.widget.RemoteViews._describeContents10703 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "describeContents", "()I");
			global::android.widget.RemoteViews._addView10704 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "addView", "(ILandroid/widget/RemoteViews;)V");
			global::android.widget.RemoteViews._setBitmap10705 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V");
			global::android.widget.RemoteViews._removeAllViews10706 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "removeAllViews", "(I)V");
			global::android.widget.RemoteViews._setTextColor10707 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setTextColor", "(II)V");
			global::android.widget.RemoteViews._getLayoutId10708 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "getLayoutId", "()I");
			global::android.widget.RemoteViews._setViewVisibility10709 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setViewVisibility", "(II)V");
			global::android.widget.RemoteViews._setTextViewText10710 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setTextViewText", "(ILjava/lang/CharSequence;)V");
			global::android.widget.RemoteViews._setImageViewResource10711 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setImageViewResource", "(II)V");
			global::android.widget.RemoteViews._setImageViewUri10712 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setImageViewUri", "(ILandroid/net/Uri;)V");
			global::android.widget.RemoteViews._setImageViewBitmap10713 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V");
			global::android.widget.RemoteViews._setChronometer10714 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setChronometer", "(IJLjava/lang/String;Z)V");
			global::android.widget.RemoteViews._setProgressBar10715 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setProgressBar", "(IIIZ)V");
			global::android.widget.RemoteViews._setOnClickPendingIntent10716 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V");
			global::android.widget.RemoteViews._setString10717 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setString", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::android.widget.RemoteViews._setCharSequence10718 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.widget.RemoteViews._setUri10719 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "setUri", "(ILjava/lang/String;Landroid/net/Uri;)V");
			global::android.widget.RemoteViews._apply10720 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.RemoteViews._reapply10721 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "reapply", "(Landroid/content/Context;Landroid/view/View;)V");
			global::android.widget.RemoteViews._onLoadClass10722 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z");
			global::android.widget.RemoteViews._RemoteViews10723 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::android.widget.RemoteViews._RemoteViews10724 = @__env.GetMethodID(global::android.widget.RemoteViews.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
