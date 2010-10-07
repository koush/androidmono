namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RingtoneManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static RingtoneManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.RingtoneManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.media.RingtoneManager(@__env);
			}
		}
		protected RingtoneManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDefault4836;
		public static bool isDefault(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._isDefault4836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setType4837;
		public virtual void setType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.RingtoneManager._setType4837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setType4837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inferStreamType4838;
		public virtual int inferStreamType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.RingtoneManager._inferStreamType4838);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._inferStreamType4838);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStopPreviousRingtone4839;
		public virtual void setStopPreviousRingtone(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.RingtoneManager._setStopPreviousRingtone4839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setStopPreviousRingtone4839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopPreviousRingtone4840;
		public virtual void stopPreviousRingtone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.RingtoneManager._stopPreviousRingtone4840);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._stopPreviousRingtone4840);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStopPreviousRingtone4841;
		public virtual bool getStopPreviousRingtone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.RingtoneManager._getStopPreviousRingtone4841);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getStopPreviousRingtone4841);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIncludeDrm4842;
		public virtual bool getIncludeDrm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.RingtoneManager._getIncludeDrm4842);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getIncludeDrm4842);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIncludeDrm4843;
		public virtual void setIncludeDrm(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.RingtoneManager._setIncludeDrm4843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setIncludeDrm4843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursor4844;
		public virtual global::android.database.Cursor getCursor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.RingtoneManager._getCursor4844));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getCursor4844));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRingtone4845;
		public virtual global::android.media.Ringtone getRingtone(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.Ringtone>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.RingtoneManager._getRingtone4845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.Ringtone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtone4845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRingtone4846;
		public static global::android.media.Ringtone getRingtone(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.Ringtone>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtone4846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRingtoneUri4847;
		public virtual global::android.net.Uri getRingtoneUri(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.RingtoneManager._getRingtoneUri4847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtoneUri4847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRingtonePosition4848;
		public virtual int getRingtonePosition(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.RingtoneManager._getRingtonePosition4848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtonePosition4848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValidRingtoneUri4849;
		public static global::android.net.Uri getValidRingtoneUri(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getValidRingtoneUri4849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActualDefaultRingtoneUri4850;
		public static global::android.net.Uri getActualDefaultRingtoneUri(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getActualDefaultRingtoneUri4850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setActualDefaultRingtoneUri4851;
		public static void setActualDefaultRingtoneUri(android.content.Context arg0, int arg1, android.net.Uri arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setActualDefaultRingtoneUri4851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultType4852;
		public static int getDefaultType(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getDefaultType4852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUri4853;
		public static global::android.net.Uri getDefaultUri(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getDefaultUri4853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RingtoneManager4854;
		public RingtoneManager(android.app.Activity arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._RingtoneManager4854, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RingtoneManager4855;
		public RingtoneManager(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._RingtoneManager4855, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int TYPE_RINGTONE
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_NOTIFICATION
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_ALARM
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_ALL
		{
			get
			{
				return 7;
			}
		}
		public static global::java.lang.String ACTION_RINGTONE_PICKER
		{
			get
			{
				return "android.intent.action.RINGTONE_PICKER";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_SHOW_DEFAULT
		{
			get
			{
				return "android.intent.extra.ringtone.SHOW_DEFAULT";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_SHOW_SILENT
		{
			get
			{
				return "android.intent.extra.ringtone.SHOW_SILENT";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_INCLUDE_DRM
		{
			get
			{
				return "android.intent.extra.ringtone.INCLUDE_DRM";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_EXISTING_URI
		{
			get
			{
				return "android.intent.extra.ringtone.EXISTING_URI";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_DEFAULT_URI
		{
			get
			{
				return "android.intent.extra.ringtone.DEFAULT_URI";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_TYPE
		{
			get
			{
				return "android.intent.extra.ringtone.TYPE";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_TITLE
		{
			get
			{
				return "android.intent.extra.ringtone.TITLE";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_PICKED_URI
		{
			get
			{
				return "android.intent.extra.ringtone.PICKED_URI";
			}
		}
		public static int ID_COLUMN_INDEX
		{
			get
			{
				return 0;
			}
		}
		public static int TITLE_COLUMN_INDEX
		{
			get
			{
				return 1;
			}
		}
		public static int URI_COLUMN_INDEX
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.RingtoneManager.staticClass = @__class;
			global::android.media.RingtoneManager._isDefault4836 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "isDefault", "(Landroid/net/Uri;)Z");
			global::android.media.RingtoneManager._setType4837 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "setType", "(I)V");
			global::android.media.RingtoneManager._inferStreamType4838 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "inferStreamType", "()I");
			global::android.media.RingtoneManager._setStopPreviousRingtone4839 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "setStopPreviousRingtone", "(Z)V");
			global::android.media.RingtoneManager._stopPreviousRingtone4840 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "stopPreviousRingtone", "()V");
			global::android.media.RingtoneManager._getStopPreviousRingtone4841 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getStopPreviousRingtone", "()Z");
			global::android.media.RingtoneManager._getIncludeDrm4842 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getIncludeDrm", "()Z");
			global::android.media.RingtoneManager._setIncludeDrm4843 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "setIncludeDrm", "(Z)V");
			global::android.media.RingtoneManager._getCursor4844 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.media.RingtoneManager._getRingtone4845 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getRingtone", "(I)Landroid/media/Ringtone;");
			global::android.media.RingtoneManager._getRingtone4846 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;");
			global::android.media.RingtoneManager._getRingtoneUri4847 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getRingtoneUri", "(I)Landroid/net/Uri;");
			global::android.media.RingtoneManager._getRingtonePosition4848 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getRingtonePosition", "(Landroid/net/Uri;)I");
			global::android.media.RingtoneManager._getValidRingtoneUri4849 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			global::android.media.RingtoneManager._getActualDefaultRingtoneUri4850 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;");
			global::android.media.RingtoneManager._setActualDefaultRingtoneUri4851 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V");
			global::android.media.RingtoneManager._getDefaultType4852 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getDefaultType", "(Landroid/net/Uri;)I");
			global::android.media.RingtoneManager._getDefaultUri4853 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getDefaultUri", "(I)Landroid/net/Uri;");
			global::android.media.RingtoneManager._RingtoneManager4854 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/app/Activity;)V");
			global::android.media.RingtoneManager._RingtoneManager4855 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
