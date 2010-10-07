namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SimpleAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::java.lang.Class staticClass;
		static SimpleAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.SimpleAdapter(@__env);
			}
		}
		protected SimpleAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ViewBinder 
		{
			bool setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2);
		}

		public partial class ViewBinder_
		{
			public static global::java.lang.Class _class
			{
				get { return __ViewBinder.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ViewBinder : java.lang.Object, ViewBinder
		{
			internal static global::java.lang.Class staticClass;
			static __ViewBinder()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleAdapter.__ViewBinder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SimpleAdapter.__ViewBinder(@__env);
				}
			}
			internal __ViewBinder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setViewValue11519;
			 bool android.widget.SimpleAdapter.ViewBinder.setViewValue(android.view.View arg0, java.lang.Object arg1, java.lang.String arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.SimpleAdapter.__ViewBinder._setViewValue11519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SimpleAdapter.__ViewBinder.staticClass, global::android.widget.SimpleAdapter.__ViewBinder._setViewValue11519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SimpleAdapter.__ViewBinder.staticClass = @__class;
				global::android.widget.SimpleAdapter.__ViewBinder._setViewValue11519 = @__env.GetMethodID(global::android.widget.SimpleAdapter.__ViewBinder.staticClass, "android.widget.SimpleAdapter.ViewBinder.setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount11520;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.SimpleAdapter._getCount11520);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getCount11520);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem11521;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleAdapter._getItem11521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getItem11521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId11522;
		public override long getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.SimpleAdapter._getItemId11522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getItemId11522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter11523;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleAdapter._getFilter11523));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getFilter11523));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView11524;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleAdapter._getView11524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getView11524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView11525;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleAdapter._getDropDownView11525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getDropDownView11525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource11526;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleAdapter._setDropDownViewResource11526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setDropDownViewResource11526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewBinder11527;
		public virtual global::android.widget.SimpleAdapter.ViewBinder getViewBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleAdapter.ViewBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleAdapter._getViewBinder11527));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleAdapter.ViewBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._getViewBinder11527));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewBinder11528;
		public virtual void setViewBinder(android.widget.SimpleAdapter.ViewBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleAdapter._setViewBinder11528, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewBinder11528, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage11529;
		public virtual void setViewImage(android.widget.ImageView arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleAdapter._setViewImage11529, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewImage11529, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage11530;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleAdapter._setViewImage11530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewImage11530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewText11531;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleAdapter._setViewText11531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._setViewText11531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleAdapter11532;
		public SimpleAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleAdapter.staticClass, global::android.widget.SimpleAdapter._SimpleAdapter11532, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.SimpleAdapter.staticClass = @__class;
			global::android.widget.SimpleAdapter._getCount11520 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getCount", "()I");
			global::android.widget.SimpleAdapter._getItem11521 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.SimpleAdapter._getItemId11522 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.SimpleAdapter._getFilter11523 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.SimpleAdapter._getView11524 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleAdapter._getDropDownView11525 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleAdapter._setDropDownViewResource11526 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.SimpleAdapter._getViewBinder11527 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;");
			global::android.widget.SimpleAdapter._setViewBinder11528 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V");
			global::android.widget.SimpleAdapter._setViewImage11529 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;I)V");
			global::android.widget.SimpleAdapter._setViewImage11530 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleAdapter._setViewText11531 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleAdapter._SimpleAdapter11532 = @__env.GetMethodID(global::android.widget.SimpleAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V");
		}
	}
}
