namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ContactsContract : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContactsContract()
		{
			InitJNI();
		}
		internal ContactsContract(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AggregationExceptions : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AggregationExceptions()
			{
				InitJNI();
			}
			internal AggregationExceptions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI10707;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.AggregationExceptions.staticClass, _CONTENT_URI10707)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/aggregation_exception";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/aggregation_exception";
				}
			}
			public static global::java.lang.String TYPE
			{
				get
				{
					return "type";
				}
			}
			public static int TYPE_AUTOMATIC
			{
				get
				{
					return 0;
				}
			}
			public static int TYPE_KEEP_TOGETHER
			{
				get
				{
					return 1;
				}
			}
			public static int TYPE_KEEP_SEPARATE
			{
				get
				{
					return 2;
				}
			}
			public static global::java.lang.String RAW_CONTACT_ID1
			{
				get
				{
					return "raw_contact_id1";
				}
			}
			public static global::java.lang.String RAW_CONTACT_ID2
			{
				get
				{
					return "raw_contact_id2";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.AggregationExceptions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$AggregationExceptions"));
				global::android.provider.ContactsContract.AggregationExceptions._CONTENT_URI10707 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.AggregationExceptions.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.BaseSyncColumns_))]
		protected partial interface BaseSyncColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.BaseSyncColumns))]
		protected sealed partial class BaseSyncColumns_ : java.lang.Object, BaseSyncColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BaseSyncColumns_()
			{
				InitJNI();
			}
			internal BaseSyncColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.BaseSyncColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$BaseSyncColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class BaseSyncColumnsConstants 
		{
			public static global::java.lang.String SYNC1
			{
				get
				{
					return "sync1";
				}
			}
			public static global::java.lang.String SYNC2
			{
				get
				{
					return "sync2";
				}
			}
			public static global::java.lang.String SYNC3
			{
				get
				{
					return "sync3";
				}
			}
			public static global::java.lang.String SYNC4
			{
				get
				{
					return "sync4";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class CommonDataKinds : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CommonDataKinds()
			{
				InitJNI();
			}
			internal CommonDataKinds(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.CommonDataKinds.BaseTypes_))]
			public partial interface BaseTypes  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.CommonDataKinds.BaseTypes))]
			public sealed partial class BaseTypes_ : java.lang.Object, BaseTypes
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static BaseTypes_()
				{
					InitJNI();
				}
				internal BaseTypes_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.BaseTypes_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$BaseTypes"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class BaseTypesConstants 
			{
				public static int TYPE_CUSTOM
				{
					get
					{
						return 0;
					}
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.CommonDataKinds.CommonColumns_))]
			protected partial interface CommonColumns : BaseTypes
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.CommonDataKinds.CommonColumns))]
			protected sealed partial class CommonColumns_ : java.lang.Object, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static CommonColumns_()
				{
					InitJNI();
				}
				internal CommonColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.CommonColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$CommonColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class CommonColumnsConstants 
			{
				public static global::java.lang.String DATA
				{
					get
					{
						return "data1";
					}
				}
				public static global::java.lang.String TYPE
				{
					get
					{
						return "data2";
					}
				}
				public static global::java.lang.String LABEL
				{
					get
					{
						return "data3";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Email : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Email()
				{
					InitJNI();
				}
				internal Email(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabelResource10724;
				public static int getTypeLabelResource(int arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Email.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Email._getTypeLabelResource10724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabel10725;
				public static global::java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.CommonDataKinds.Email.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Email._getTypeLabel10725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/email_v2";
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/email_v2";
					}
				}
				internal static global::MonoJavaBridge.FieldId _CONTENT_URI10728;
				public static global::android.net.Uri CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, _CONTENT_URI10728)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _CONTENT_LOOKUP_URI10729;
				public static global::android.net.Uri CONTENT_LOOKUP_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, _CONTENT_LOOKUP_URI10729)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URI10730;
				public static global::android.net.Uri CONTENT_FILTER_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, _CONTENT_FILTER_URI10730)) as android.net.Uri;
					}
				}
				public static int TYPE_HOME
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_WORK
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 3;
					}
				}
				public static int TYPE_MOBILE
				{
					get
					{
						return 4;
					}
				}
				public static global::java.lang.String DISPLAY_NAME
				{
					get
					{
						return "data4";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Email"));
					global::android.provider.ContactsContract.CommonDataKinds.Email._getTypeLabelResource10724 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "getTypeLabelResource", "(I)I");
					global::android.provider.ContactsContract.CommonDataKinds.Email._getTypeLabel10725 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
					global::android.provider.ContactsContract.CommonDataKinds.Email._CONTENT_URI10728 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.ContactsContract.CommonDataKinds.Email._CONTENT_LOOKUP_URI10729 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "CONTENT_LOOKUP_URI", "Landroid/net/Uri;");
					global::android.provider.ContactsContract.CommonDataKinds.Email._CONTENT_FILTER_URI10730 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "CONTENT_FILTER_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Event : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Event()
				{
					InitJNI();
				}
				internal Event(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getTypeResource10736;
				public static int getTypeResource(java.lang.Integer arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Event.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Event._getTypeResource10736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/contact_event";
					}
				}
				public static int TYPE_ANNIVERSARY
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_BIRTHDAY
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String START_DATE
				{
					get
					{
						return "data1";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Event.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Event"));
					global::android.provider.ContactsContract.CommonDataKinds.Event._getTypeResource10736 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Event.staticClass, "getTypeResource", "(Ljava/lang/Integer;)I");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class GroupMembership : java.lang.Object, DataColumnsWithJoins
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static GroupMembership()
				{
					InitJNI();
				}
				internal GroupMembership(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/group_membership";
					}
				}
				public static global::java.lang.String GROUP_ROW_ID
				{
					get
					{
						return "data1";
					}
				}
				public static global::java.lang.String GROUP_SOURCE_ID
				{
					get
					{
						return "group_sourceid";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.GroupMembership.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$GroupMembership"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Im : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Im()
				{
					InitJNI();
				}
				internal Im(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabelResource10745;
				public static int getTypeLabelResource(int arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Im._getTypeLabelResource10745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabel10746;
				public static global::java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Im._getTypeLabel10746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
				}
				internal static global::MonoJavaBridge.MethodId _getProtocolLabelResource10747;
				public static int getProtocolLabelResource(int arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Im._getProtocolLabelResource10747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				internal static global::MonoJavaBridge.MethodId _getProtocolLabel10748;
				public static global::java.lang.CharSequence getProtocolLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Im._getProtocolLabel10748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/im";
					}
				}
				public static int TYPE_HOME
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_WORK
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String PROTOCOL
				{
					get
					{
						return "data5";
					}
				}
				public static global::java.lang.String CUSTOM_PROTOCOL
				{
					get
					{
						return "data6";
					}
				}
				public static int PROTOCOL_CUSTOM
				{
					get
					{
						return -1;
					}
				}
				public static int PROTOCOL_AIM
				{
					get
					{
						return 0;
					}
				}
				public static int PROTOCOL_MSN
				{
					get
					{
						return 1;
					}
				}
				public static int PROTOCOL_YAHOO
				{
					get
					{
						return 2;
					}
				}
				public static int PROTOCOL_SKYPE
				{
					get
					{
						return 3;
					}
				}
				public static int PROTOCOL_QQ
				{
					get
					{
						return 4;
					}
				}
				public static int PROTOCOL_GOOGLE_TALK
				{
					get
					{
						return 5;
					}
				}
				public static int PROTOCOL_ICQ
				{
					get
					{
						return 6;
					}
				}
				public static int PROTOCOL_JABBER
				{
					get
					{
						return 7;
					}
				}
				public static int PROTOCOL_NETMEETING
				{
					get
					{
						return 8;
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Im"));
					global::android.provider.ContactsContract.CommonDataKinds.Im._getTypeLabelResource10745 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getTypeLabelResource", "(I)I");
					global::android.provider.ContactsContract.CommonDataKinds.Im._getTypeLabel10746 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
					global::android.provider.ContactsContract.CommonDataKinds.Im._getProtocolLabelResource10747 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getProtocolLabelResource", "(I)I");
					global::android.provider.ContactsContract.CommonDataKinds.Im._getProtocolLabel10748 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getProtocolLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Nickname : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Nickname()
				{
					InitJNI();
				}
				internal Nickname(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/nickname";
					}
				}
				public static int TYPE_DEFAULT
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_OTHER_NAME
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_MAINDEN_NAME
				{
					get
					{
						return 3;
					}
				}
				public static int TYPE_SHORT_NAME
				{
					get
					{
						return 4;
					}
				}
				public static int TYPE_INITIALS
				{
					get
					{
						return 5;
					}
				}
				public static global::java.lang.String NAME
				{
					get
					{
						return "data1";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Nickname.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Nickname"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Note : java.lang.Object, DataColumnsWithJoins
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Note()
				{
					InitJNI();
				}
				internal Note(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/note";
					}
				}
				public static global::java.lang.String NOTE
				{
					get
					{
						return "data1";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Note.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Note"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Organization : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Organization()
				{
					InitJNI();
				}
				internal Organization(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabelResource10774;
				public static int getTypeLabelResource(int arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Organization._getTypeLabelResource10774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabel10775;
				public static global::java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Organization._getTypeLabel10775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/organization";
					}
				}
				public static int TYPE_WORK
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 2;
					}
				}
				public static global::java.lang.String COMPANY
				{
					get
					{
						return "data1";
					}
				}
				public static global::java.lang.String TITLE
				{
					get
					{
						return "data4";
					}
				}
				public static global::java.lang.String DEPARTMENT
				{
					get
					{
						return "data5";
					}
				}
				public static global::java.lang.String JOB_DESCRIPTION
				{
					get
					{
						return "data6";
					}
				}
				public static global::java.lang.String SYMBOL
				{
					get
					{
						return "data7";
					}
				}
				public static global::java.lang.String PHONETIC_NAME
				{
					get
					{
						return "data8";
					}
				}
				public static global::java.lang.String OFFICE_LOCATION
				{
					get
					{
						return "data9";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Organization.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Organization"));
					global::android.provider.ContactsContract.CommonDataKinds.Organization._getTypeLabelResource10774 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, "getTypeLabelResource", "(I)I");
					global::android.provider.ContactsContract.CommonDataKinds.Organization._getTypeLabel10775 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Phone : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Phone()
				{
					InitJNI();
				}
				internal Phone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabelResource10786;
				public static int getTypeLabelResource(int arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Phone._getTypeLabelResource10786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabel10787;
				public static global::java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, global::android.provider.ContactsContract.CommonDataKinds.Phone._getTypeLabel10787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/phone_v2";
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/phone_v2";
					}
				}
				internal static global::MonoJavaBridge.FieldId _CONTENT_URI10790;
				public static global::android.net.Uri CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, _CONTENT_URI10790)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URI10791;
				public static global::android.net.Uri CONTENT_FILTER_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, _CONTENT_FILTER_URI10791)) as android.net.Uri;
					}
				}
				public static int TYPE_HOME
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_MOBILE
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_WORK
				{
					get
					{
						return 3;
					}
				}
				public static int TYPE_FAX_WORK
				{
					get
					{
						return 4;
					}
				}
				public static int TYPE_FAX_HOME
				{
					get
					{
						return 5;
					}
				}
				public static int TYPE_PAGER
				{
					get
					{
						return 6;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 7;
					}
				}
				public static int TYPE_CALLBACK
				{
					get
					{
						return 8;
					}
				}
				public static int TYPE_CAR
				{
					get
					{
						return 9;
					}
				}
				public static int TYPE_COMPANY_MAIN
				{
					get
					{
						return 10;
					}
				}
				public static int TYPE_ISDN
				{
					get
					{
						return 11;
					}
				}
				public static int TYPE_MAIN
				{
					get
					{
						return 12;
					}
				}
				public static int TYPE_OTHER_FAX
				{
					get
					{
						return 13;
					}
				}
				public static int TYPE_RADIO
				{
					get
					{
						return 14;
					}
				}
				public static int TYPE_TELEX
				{
					get
					{
						return 15;
					}
				}
				public static int TYPE_TTY_TDD
				{
					get
					{
						return 16;
					}
				}
				public static int TYPE_WORK_MOBILE
				{
					get
					{
						return 17;
					}
				}
				public static int TYPE_WORK_PAGER
				{
					get
					{
						return 18;
					}
				}
				public static int TYPE_ASSISTANT
				{
					get
					{
						return 19;
					}
				}
				public static int TYPE_MMS
				{
					get
					{
						return 20;
					}
				}
				public static global::java.lang.String NUMBER
				{
					get
					{
						return "data1";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Phone"));
					global::android.provider.ContactsContract.CommonDataKinds.Phone._getTypeLabelResource10786 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, "getTypeLabelResource", "(I)I");
					global::android.provider.ContactsContract.CommonDataKinds.Phone._getTypeLabel10787 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
					global::android.provider.ContactsContract.CommonDataKinds.Phone._CONTENT_URI10790 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.ContactsContract.CommonDataKinds.Phone._CONTENT_FILTER_URI10791 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, "CONTENT_FILTER_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Photo : java.lang.Object, DataColumnsWithJoins
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Photo()
				{
					InitJNI();
				}
				internal Photo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/photo";
					}
				}
				public static global::java.lang.String PHOTO
				{
					get
					{
						return "data15";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Photo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Photo"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Relation : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Relation()
				{
					InitJNI();
				}
				internal Relation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/relation";
					}
				}
				public static int TYPE_ASSISTANT
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_BROTHER
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_CHILD
				{
					get
					{
						return 3;
					}
				}
				public static int TYPE_DOMESTIC_PARTNER
				{
					get
					{
						return 4;
					}
				}
				public static int TYPE_FATHER
				{
					get
					{
						return 5;
					}
				}
				public static int TYPE_FRIEND
				{
					get
					{
						return 6;
					}
				}
				public static int TYPE_MANAGER
				{
					get
					{
						return 7;
					}
				}
				public static int TYPE_MOTHER
				{
					get
					{
						return 8;
					}
				}
				public static int TYPE_PARENT
				{
					get
					{
						return 9;
					}
				}
				public static int TYPE_PARTNER
				{
					get
					{
						return 10;
					}
				}
				public static int TYPE_REFERRED_BY
				{
					get
					{
						return 11;
					}
				}
				public static int TYPE_RELATIVE
				{
					get
					{
						return 12;
					}
				}
				public static int TYPE_SISTER
				{
					get
					{
						return 13;
					}
				}
				public static int TYPE_SPOUSE
				{
					get
					{
						return 14;
					}
				}
				public static global::java.lang.String NAME
				{
					get
					{
						return "data1";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Relation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Relation"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class StructuredName : java.lang.Object, DataColumnsWithJoins
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static StructuredName()
				{
					InitJNI();
				}
				internal StructuredName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/name";
					}
				}
				public static global::java.lang.String DISPLAY_NAME
				{
					get
					{
						return "data1";
					}
				}
				public static global::java.lang.String GIVEN_NAME
				{
					get
					{
						return "data2";
					}
				}
				public static global::java.lang.String FAMILY_NAME
				{
					get
					{
						return "data3";
					}
				}
				public static global::java.lang.String PREFIX
				{
					get
					{
						return "data4";
					}
				}
				public static global::java.lang.String MIDDLE_NAME
				{
					get
					{
						return "data5";
					}
				}
				public static global::java.lang.String SUFFIX
				{
					get
					{
						return "data6";
					}
				}
				public static global::java.lang.String PHONETIC_GIVEN_NAME
				{
					get
					{
						return "data7";
					}
				}
				public static global::java.lang.String PHONETIC_MIDDLE_NAME
				{
					get
					{
						return "data8";
					}
				}
				public static global::java.lang.String PHONETIC_FAMILY_NAME
				{
					get
					{
						return "data9";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.StructuredName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$StructuredName"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class StructuredPostal : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static StructuredPostal()
				{
					InitJNI();
				}
				internal StructuredPostal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabelResource10841;
				public static int getTypeLabelResource(int arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._getTypeLabelResource10841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				}
				internal static global::MonoJavaBridge.MethodId _getTypeLabel10842;
				public static global::java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._getTypeLabel10842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/postal-address_v2";
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/postal-address_v2";
					}
				}
				internal static global::MonoJavaBridge.FieldId _CONTENT_URI10845;
				public static global::android.net.Uri CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, _CONTENT_URI10845)) as android.net.Uri;
					}
				}
				public static int TYPE_HOME
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_WORK
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String FORMATTED_ADDRESS
				{
					get
					{
						return "data1";
					}
				}
				public static global::java.lang.String STREET
				{
					get
					{
						return "data4";
					}
				}
				public static global::java.lang.String POBOX
				{
					get
					{
						return "data5";
					}
				}
				public static global::java.lang.String NEIGHBORHOOD
				{
					get
					{
						return "data6";
					}
				}
				public static global::java.lang.String CITY
				{
					get
					{
						return "data7";
					}
				}
				public static global::java.lang.String REGION
				{
					get
					{
						return "data8";
					}
				}
				public static global::java.lang.String POSTCODE
				{
					get
					{
						return "data9";
					}
				}
				public static global::java.lang.String COUNTRY
				{
					get
					{
						return "data10";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$StructuredPostal"));
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._getTypeLabelResource10841 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, "getTypeLabelResource", "(I)I");
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._getTypeLabel10842 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._CONTENT_URI10845 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Website : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Website()
				{
					InitJNI();
				}
				internal Website(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_ITEM_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/website";
					}
				}
				public static int TYPE_HOMEPAGE
				{
					get
					{
						return 1;
					}
				}
				public static int TYPE_BLOG
				{
					get
					{
						return 2;
					}
				}
				public static int TYPE_PROFILE
				{
					get
					{
						return 3;
					}
				}
				public static int TYPE_HOME
				{
					get
					{
						return 4;
					}
				}
				public static int TYPE_WORK
				{
					get
					{
						return 5;
					}
				}
				public static int TYPE_FTP
				{
					get
					{
						return 6;
					}
				}
				public static int TYPE_OTHER
				{
					get
					{
						return 7;
					}
				}
				public static global::java.lang.String URL
				{
					get
					{
						return "data1";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.CommonDataKinds.Website.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds$Website"));
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.CommonDataKinds.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$CommonDataKinds"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.ContactOptionsColumns_))]
		protected partial interface ContactOptionsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.ContactOptionsColumns))]
		protected sealed partial class ContactOptionsColumns_ : java.lang.Object, ContactOptionsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ContactOptionsColumns_()
			{
				InitJNI();
			}
			internal ContactOptionsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.ContactOptionsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$ContactOptionsColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class ContactOptionsColumnsConstants 
		{
			public static global::java.lang.String TIMES_CONTACTED
			{
				get
				{
					return "times_contacted";
				}
			}
			public static global::java.lang.String LAST_TIME_CONTACTED
			{
				get
				{
					return "last_time_contacted";
				}
			}
			public static global::java.lang.String STARRED
			{
				get
				{
					return "starred";
				}
			}
			public static global::java.lang.String CUSTOM_RINGTONE
			{
				get
				{
					return "custom_ringtone";
				}
			}
			public static global::java.lang.String SEND_TO_VOICEMAIL
			{
				get
				{
					return "send_to_voicemail";
				}
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.ContactStatusColumns_))]
		protected partial interface ContactStatusColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.ContactStatusColumns))]
		protected sealed partial class ContactStatusColumns_ : java.lang.Object, ContactStatusColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ContactStatusColumns_()
			{
				InitJNI();
			}
			internal ContactStatusColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.ContactStatusColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$ContactStatusColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class ContactStatusColumnsConstants 
		{
			public static global::java.lang.String CONTACT_PRESENCE
			{
				get
				{
					return "contact_presence";
				}
			}
			public static global::java.lang.String CONTACT_STATUS
			{
				get
				{
					return "contact_status";
				}
			}
			public static global::java.lang.String CONTACT_STATUS_TIMESTAMP
			{
				get
				{
					return "contact_status_ts";
				}
			}
			public static global::java.lang.String CONTACT_STATUS_RES_PACKAGE
			{
				get
				{
					return "contact_status_res_package";
				}
			}
			public static global::java.lang.String CONTACT_STATUS_LABEL
			{
				get
				{
					return "contact_status_label";
				}
			}
			public static global::java.lang.String CONTACT_STATUS_ICON
			{
				get
				{
					return "contact_status_icon";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Contacts : java.lang.Object, BaseColumns, ContactsColumns, ContactOptionsColumns, ContactStatusColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Contacts()
			{
				InitJNI();
			}
			protected Contacts(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class AggregationSuggestions : java.lang.Object, BaseColumns, ContactsColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static AggregationSuggestions()
				{
					InitJNI();
				}
				internal AggregationSuggestions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "suggestions";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.Contacts.AggregationSuggestions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Contacts$AggregationSuggestions"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Data : java.lang.Object, BaseColumns, DataColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Data()
				{
					InitJNI();
				}
				internal Data(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "data";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.Contacts.Data.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Contacts$Data"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Photo : java.lang.Object, BaseColumns, DataColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Photo()
				{
					InitJNI();
				}
				internal Photo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "photo";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.Contacts.Photo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Contacts$Photo"));
				}
			}
			internal static global::MonoJavaBridge.MethodId _markAsContacted10880;
			public static void markAsContacted(android.content.ContentResolver arg0, long arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.Contacts.staticClass, global::android.provider.ContactsContract.Contacts._markAsContacted10880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _openContactPhotoInputStream10881;
			public static global::java.io.InputStream openContactPhotoInputStream(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.Contacts.staticClass, global::android.provider.ContactsContract.Contacts._openContactPhotoInputStream10881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
			}
			internal static global::MonoJavaBridge.MethodId _getLookupUri10882;
			public static global::android.net.Uri getLookupUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.Contacts.staticClass, global::android.provider.ContactsContract.Contacts._getLookupUri10882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _getLookupUri10883;
			public static global::android.net.Uri getLookupUri(long arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.Contacts.staticClass, global::android.provider.ContactsContract.Contacts._getLookupUri10883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _lookupContact10884;
			public static global::android.net.Uri lookupContact(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.Contacts.staticClass, global::android.provider.ContactsContract.Contacts._lookupContact10884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI10885;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_URI10885)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_LOOKUP_URI10886;
			public static global::android.net.Uri CONTENT_LOOKUP_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_LOOKUP_URI10886)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_VCARD_URI10887;
			public static global::android.net.Uri CONTENT_VCARD_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_VCARD_URI10887)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URI10888;
			public static global::android.net.Uri CONTENT_FILTER_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_FILTER_URI10888)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_STREQUENT_URI10889;
			public static global::android.net.Uri CONTENT_STREQUENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_STREQUENT_URI10889)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_STREQUENT_FILTER_URI10890;
			public static global::android.net.Uri CONTENT_STREQUENT_FILTER_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_STREQUENT_FILTER_URI10890)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_GROUP_URI10891;
			public static global::android.net.Uri CONTENT_GROUP_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Contacts.staticClass, _CONTENT_GROUP_URI10891)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/contact";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/contact";
				}
			}
			public static global::java.lang.String CONTENT_VCARD_TYPE
			{
				get
				{
					return "text/x-vcard";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.Contacts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Contacts"));
				global::android.provider.ContactsContract.Contacts._markAsContacted10880 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "markAsContacted", "(Landroid/content/ContentResolver;J)V");
				global::android.provider.ContactsContract.Contacts._openContactPhotoInputStream10881 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;");
				global::android.provider.ContactsContract.Contacts._getLookupUri10882 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "getLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._getLookupUri10883 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "getLookupUri", "(JLjava/lang/String;)Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._lookupContact10884 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "lookupContact", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_URI10885 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_LOOKUP_URI10886 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_LOOKUP_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_VCARD_URI10887 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_VCARD_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_FILTER_URI10888 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_FILTER_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_STREQUENT_URI10889 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_STREQUENT_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_STREQUENT_FILTER_URI10890 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_STREQUENT_FILTER_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Contacts._CONTENT_GROUP_URI10891 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Contacts.staticClass, "CONTENT_GROUP_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.ContactsColumns_))]
		protected partial interface ContactsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.ContactsColumns))]
		protected sealed partial class ContactsColumns_ : java.lang.Object, ContactsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ContactsColumns_()
			{
				InitJNI();
			}
			internal ContactsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.ContactsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$ContactsColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class ContactsColumnsConstants 
		{
			public static global::java.lang.String DISPLAY_NAME
			{
				get
				{
					return "display_name";
				}
			}
			public static global::java.lang.String PHOTO_ID
			{
				get
				{
					return "photo_id";
				}
			}
			public static global::java.lang.String IN_VISIBLE_GROUP
			{
				get
				{
					return "in_visible_group";
				}
			}
			public static global::java.lang.String HAS_PHONE_NUMBER
			{
				get
				{
					return "has_phone_number";
				}
			}
			public static global::java.lang.String LOOKUP_KEY
			{
				get
				{
					return "lookup";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Data : java.lang.Object, DataColumnsWithJoins
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Data()
			{
				InitJNI();
			}
			internal Data(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getContactLookupUri10900;
			public static global::android.net.Uri getContactLookupUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.Data.staticClass, global::android.provider.ContactsContract.Data._getContactLookupUri10900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI10901;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Data.staticClass, _CONTENT_URI10901)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/data";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.Data.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Data"));
				global::android.provider.ContactsContract.Data._getContactLookupUri10900 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Data.staticClass, "getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;");
				global::android.provider.ContactsContract.Data._CONTENT_URI10901 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Data.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.DataColumns_))]
		protected partial interface DataColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.DataColumns))]
		protected sealed partial class DataColumns_ : java.lang.Object, DataColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DataColumns_()
			{
				InitJNI();
			}
			internal DataColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.DataColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$DataColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class DataColumnsConstants 
		{
			public static global::java.lang.String MIMETYPE
			{
				get
				{
					return "mimetype";
				}
			}
			public static global::java.lang.String RAW_CONTACT_ID
			{
				get
				{
					return "raw_contact_id";
				}
			}
			public static global::java.lang.String IS_PRIMARY
			{
				get
				{
					return "is_primary";
				}
			}
			public static global::java.lang.String IS_SUPER_PRIMARY
			{
				get
				{
					return "is_super_primary";
				}
			}
			public static global::java.lang.String DATA_VERSION
			{
				get
				{
					return "data_version";
				}
			}
			public static global::java.lang.String DATA1
			{
				get
				{
					return "data1";
				}
			}
			public static global::java.lang.String DATA2
			{
				get
				{
					return "data2";
				}
			}
			public static global::java.lang.String DATA3
			{
				get
				{
					return "data3";
				}
			}
			public static global::java.lang.String DATA4
			{
				get
				{
					return "data4";
				}
			}
			public static global::java.lang.String DATA5
			{
				get
				{
					return "data5";
				}
			}
			public static global::java.lang.String DATA6
			{
				get
				{
					return "data6";
				}
			}
			public static global::java.lang.String DATA7
			{
				get
				{
					return "data7";
				}
			}
			public static global::java.lang.String DATA8
			{
				get
				{
					return "data8";
				}
			}
			public static global::java.lang.String DATA9
			{
				get
				{
					return "data9";
				}
			}
			public static global::java.lang.String DATA10
			{
				get
				{
					return "data10";
				}
			}
			public static global::java.lang.String DATA11
			{
				get
				{
					return "data11";
				}
			}
			public static global::java.lang.String DATA12
			{
				get
				{
					return "data12";
				}
			}
			public static global::java.lang.String DATA13
			{
				get
				{
					return "data13";
				}
			}
			public static global::java.lang.String DATA14
			{
				get
				{
					return "data14";
				}
			}
			public static global::java.lang.String DATA15
			{
				get
				{
					return "data15";
				}
			}
			public static global::java.lang.String SYNC1
			{
				get
				{
					return "data_sync1";
				}
			}
			public static global::java.lang.String SYNC2
			{
				get
				{
					return "data_sync2";
				}
			}
			public static global::java.lang.String SYNC3
			{
				get
				{
					return "data_sync3";
				}
			}
			public static global::java.lang.String SYNC4
			{
				get
				{
					return "data_sync4";
				}
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.DataColumnsWithJoins_))]
		protected partial interface DataColumnsWithJoins : BaseColumns, DataColumns, StatusColumns, RawContactsColumns, ContactsColumns, ContactOptionsColumns, ContactStatusColumns
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.DataColumnsWithJoins))]
		protected sealed partial class DataColumnsWithJoins_ : java.lang.Object, DataColumnsWithJoins
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DataColumnsWithJoins_()
			{
				InitJNI();
			}
			internal DataColumnsWithJoins_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.DataColumnsWithJoins_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$DataColumnsWithJoins"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Groups : java.lang.Object, BaseColumns, GroupsColumns, SyncColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Groups()
			{
				InitJNI();
			}
			internal Groups(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newEntityIterator10927;
			public static global::android.content.EntityIterator newEntityIterator(android.database.Cursor arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.EntityIterator>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.Groups.staticClass, global::android.provider.ContactsContract.Groups._newEntityIterator10927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.EntityIterator;
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI10928;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Groups.staticClass, _CONTENT_URI10928)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_SUMMARY_URI10929;
			public static global::android.net.Uri CONTENT_SUMMARY_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Groups.staticClass, _CONTENT_SUMMARY_URI10929)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/group";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/group";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.Groups.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Groups"));
				global::android.provider.ContactsContract.Groups._newEntityIterator10927 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.Groups.staticClass, "newEntityIterator", "(Landroid/database/Cursor;)Landroid/content/EntityIterator;");
				global::android.provider.ContactsContract.Groups._CONTENT_URI10928 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Groups.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.ContactsContract.Groups._CONTENT_SUMMARY_URI10929 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Groups.staticClass, "CONTENT_SUMMARY_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.GroupsColumns_))]
		protected partial interface GroupsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.GroupsColumns))]
		protected sealed partial class GroupsColumns_ : java.lang.Object, GroupsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static GroupsColumns_()
			{
				InitJNI();
			}
			internal GroupsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.GroupsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$GroupsColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class GroupsColumnsConstants 
		{
			public static global::java.lang.String TITLE
			{
				get
				{
					return "title";
				}
			}
			public static global::java.lang.String NOTES
			{
				get
				{
					return "notes";
				}
			}
			public static global::java.lang.String SYSTEM_ID
			{
				get
				{
					return "system_id";
				}
			}
			public static global::java.lang.String SUMMARY_COUNT
			{
				get
				{
					return "summ_count";
				}
			}
			public static global::java.lang.String SUMMARY_WITH_PHONES
			{
				get
				{
					return "summ_phones";
				}
			}
			public static global::java.lang.String GROUP_VISIBLE
			{
				get
				{
					return "group_visible";
				}
			}
			public static global::java.lang.String DELETED
			{
				get
				{
					return "deleted";
				}
			}
			public static global::java.lang.String SHOULD_SYNC
			{
				get
				{
					return "should_sync";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Intents : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Intents()
			{
				InitJNI();
			}
			internal Intents(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Insert : java.lang.Object
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Insert()
				{
					InitJNI();
				}
				internal Insert(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _Insert10940;
				public Insert()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.ContactsContract.Intents.Insert.staticClass, global::android.provider.ContactsContract.Intents.Insert._Insert10940);
					Init(@__env, handle);
				}
				public static global::java.lang.String ACTION
				{
					get
					{
						return "android.intent.action.INSERT";
					}
				}
				public static global::java.lang.String FULL_MODE
				{
					get
					{
						return "full_mode";
					}
				}
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
				public static global::java.lang.String PHONETIC_NAME
				{
					get
					{
						return "phonetic_name";
					}
				}
				public static global::java.lang.String COMPANY
				{
					get
					{
						return "company";
					}
				}
				public static global::java.lang.String JOB_TITLE
				{
					get
					{
						return "job_title";
					}
				}
				public static global::java.lang.String NOTES
				{
					get
					{
						return "notes";
					}
				}
				public static global::java.lang.String PHONE
				{
					get
					{
						return "phone";
					}
				}
				public static global::java.lang.String PHONE_TYPE
				{
					get
					{
						return "phone_type";
					}
				}
				public static global::java.lang.String PHONE_ISPRIMARY
				{
					get
					{
						return "phone_isprimary";
					}
				}
				public static global::java.lang.String SECONDARY_PHONE
				{
					get
					{
						return "secondary_phone";
					}
				}
				public static global::java.lang.String SECONDARY_PHONE_TYPE
				{
					get
					{
						return "secondary_phone_type";
					}
				}
				public static global::java.lang.String TERTIARY_PHONE
				{
					get
					{
						return "tertiary_phone";
					}
				}
				public static global::java.lang.String TERTIARY_PHONE_TYPE
				{
					get
					{
						return "tertiary_phone_type";
					}
				}
				public static global::java.lang.String EMAIL
				{
					get
					{
						return "email";
					}
				}
				public static global::java.lang.String EMAIL_TYPE
				{
					get
					{
						return "email_type";
					}
				}
				public static global::java.lang.String EMAIL_ISPRIMARY
				{
					get
					{
						return "email_isprimary";
					}
				}
				public static global::java.lang.String SECONDARY_EMAIL
				{
					get
					{
						return "secondary_email";
					}
				}
				public static global::java.lang.String SECONDARY_EMAIL_TYPE
				{
					get
					{
						return "secondary_email_type";
					}
				}
				public static global::java.lang.String TERTIARY_EMAIL
				{
					get
					{
						return "tertiary_email";
					}
				}
				public static global::java.lang.String TERTIARY_EMAIL_TYPE
				{
					get
					{
						return "tertiary_email_type";
					}
				}
				public static global::java.lang.String POSTAL
				{
					get
					{
						return "postal";
					}
				}
				public static global::java.lang.String POSTAL_TYPE
				{
					get
					{
						return "postal_type";
					}
				}
				public static global::java.lang.String POSTAL_ISPRIMARY
				{
					get
					{
						return "postal_isprimary";
					}
				}
				public static global::java.lang.String IM_HANDLE
				{
					get
					{
						return "im_handle";
					}
				}
				public static global::java.lang.String IM_PROTOCOL
				{
					get
					{
						return "im_protocol";
					}
				}
				public static global::java.lang.String IM_ISPRIMARY
				{
					get
					{
						return "im_isprimary";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.Intents.Insert.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Intents$Insert"));
					global::android.provider.ContactsContract.Intents.Insert._Insert10940 = @__env.GetMethodIDNoThrow(global::android.provider.ContactsContract.Intents.Insert.staticClass, "<init>", "()V");
				}
			}
			internal static global::MonoJavaBridge.MethodId _Intents10968;
			public Intents()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.ContactsContract.Intents.staticClass, global::android.provider.ContactsContract.Intents._Intents10968);
				Init(@__env, handle);
			}
			public static global::java.lang.String SEARCH_SUGGESTION_CLICKED
			{
				get
				{
					return "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED";
				}
			}
			public static global::java.lang.String SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
			{
				get
				{
					return "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED";
				}
			}
			public static global::java.lang.String SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
			{
				get
				{
					return "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED";
				}
			}
			public static global::java.lang.String ATTACH_IMAGE
			{
				get
				{
					return "com.android.contacts.action.ATTACH_IMAGE";
				}
			}
			public static global::java.lang.String SHOW_OR_CREATE_CONTACT
			{
				get
				{
					return "com.android.contacts.action.SHOW_OR_CREATE_CONTACT";
				}
			}
			public static global::java.lang.String EXTRA_FORCE_CREATE
			{
				get
				{
					return "com.android.contacts.action.FORCE_CREATE";
				}
			}
			public static global::java.lang.String EXTRA_CREATE_DESCRIPTION
			{
				get
				{
					return "com.android.contacts.action.CREATE_DESCRIPTION";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.Intents.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Intents"));
				global::android.provider.ContactsContract.Intents._Intents10968 = @__env.GetMethodIDNoThrow(global::android.provider.ContactsContract.Intents.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class PhoneLookup : java.lang.Object, BaseColumns, PhoneLookupColumns, ContactsColumns, ContactOptionsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PhoneLookup()
			{
				InitJNI();
			}
			internal PhoneLookup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URI10976;
			public static global::android.net.Uri CONTENT_FILTER_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.PhoneLookup.staticClass, _CONTENT_FILTER_URI10976)) as android.net.Uri;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.PhoneLookup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$PhoneLookup"));
				global::android.provider.ContactsContract.PhoneLookup._CONTENT_FILTER_URI10976 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.PhoneLookup.staticClass, "CONTENT_FILTER_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.PhoneLookupColumns_))]
		protected partial interface PhoneLookupColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.PhoneLookupColumns))]
		protected sealed partial class PhoneLookupColumns_ : java.lang.Object, PhoneLookupColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PhoneLookupColumns_()
			{
				InitJNI();
			}
			internal PhoneLookupColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.PhoneLookupColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$PhoneLookupColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PhoneLookupColumnsConstants 
		{
			public static global::java.lang.String NUMBER
			{
				get
				{
					return "number";
				}
			}
			public static global::java.lang.String TYPE
			{
				get
				{
					return "type";
				}
			}
			public static global::java.lang.String LABEL
			{
				get
				{
					return "label";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Presence : android.provider.ContactsContract.StatusUpdates
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Presence()
			{
				InitJNI();
			}
			internal Presence(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Presence10980;
			public Presence()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.ContactsContract.Presence.staticClass, global::android.provider.ContactsContract.Presence._Presence10980);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.Presence.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Presence"));
				global::android.provider.ContactsContract.Presence._Presence10980 = @__env.GetMethodIDNoThrow(global::android.provider.ContactsContract.Presence.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.PresenceColumns_))]
		protected partial interface PresenceColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.PresenceColumns))]
		protected sealed partial class PresenceColumns_ : java.lang.Object, PresenceColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PresenceColumns_()
			{
				InitJNI();
			}
			internal PresenceColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.PresenceColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$PresenceColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PresenceColumnsConstants 
		{
			public static global::java.lang.String DATA_ID
			{
				get
				{
					return "presence_data_id";
				}
			}
			public static global::java.lang.String PROTOCOL
			{
				get
				{
					return "protocol";
				}
			}
			public static global::java.lang.String CUSTOM_PROTOCOL
			{
				get
				{
					return "custom_protocol";
				}
			}
			public static global::java.lang.String IM_HANDLE
			{
				get
				{
					return "im_handle";
				}
			}
			public static global::java.lang.String IM_ACCOUNT
			{
				get
				{
					return "im_account";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class QuickContact : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static QuickContact()
			{
				InitJNI();
			}
			internal QuickContact(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _showQuickContact10986;
			public static void showQuickContact(android.content.Context arg0, android.view.View arg1, android.net.Uri arg2, int arg3, java.lang.String[] arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.QuickContact.staticClass, global::android.provider.ContactsContract.QuickContact._showQuickContact10986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			internal static global::MonoJavaBridge.MethodId _showQuickContact10987;
			public static void showQuickContact(android.content.Context arg0, android.graphics.Rect arg1, android.net.Uri arg2, int arg3, java.lang.String[] arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.QuickContact.staticClass, global::android.provider.ContactsContract.QuickContact._showQuickContact10987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			internal static global::MonoJavaBridge.MethodId _QuickContact10988;
			public QuickContact()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.ContactsContract.QuickContact.staticClass, global::android.provider.ContactsContract.QuickContact._QuickContact10988);
				Init(@__env, handle);
			}
			public static int MODE_SMALL
			{
				get
				{
					return 1;
				}
			}
			public static int MODE_MEDIUM
			{
				get
				{
					return 2;
				}
			}
			public static int MODE_LARGE
			{
				get
				{
					return 3;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.QuickContact.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$QuickContact"));
				global::android.provider.ContactsContract.QuickContact._showQuickContact10986 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.QuickContact.staticClass, "showQuickContact", "(Landroid/content/Context;Landroid/view/View;Landroid/net/Uri;I[Ljava/lang/String;)V");
				global::android.provider.ContactsContract.QuickContact._showQuickContact10987 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.QuickContact.staticClass, "showQuickContact", "(Landroid/content/Context;Landroid/graphics/Rect;Landroid/net/Uri;I[Ljava/lang/String;)V");
				global::android.provider.ContactsContract.QuickContact._QuickContact10988 = @__env.GetMethodIDNoThrow(global::android.provider.ContactsContract.QuickContact.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RawContacts : java.lang.Object, BaseColumns, RawContactsColumns, ContactOptionsColumns, SyncColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RawContacts()
			{
				InitJNI();
			}
			internal RawContacts(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Data : java.lang.Object, BaseColumns, DataColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Data()
				{
					InitJNI();
				}
				internal Data(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "data";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.RawContacts.Data.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$RawContacts$Data"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Entity : java.lang.Object, BaseColumns, DataColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Entity()
				{
					InitJNI();
				}
				internal Entity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "entity";
					}
				}
				public static global::java.lang.String DATA_ID
				{
					get
					{
						return "data_id";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.ContactsContract.RawContacts.Entity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$RawContacts$Entity"));
				}
			}
			internal static global::MonoJavaBridge.MethodId _newEntityIterator10995;
			public static global::android.content.EntityIterator newEntityIterator(android.database.Cursor arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.EntityIterator>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.RawContacts.staticClass, global::android.provider.ContactsContract.RawContacts._newEntityIterator10995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.EntityIterator;
			}
			internal static global::MonoJavaBridge.MethodId _getContactLookupUri10996;
			public static global::android.net.Uri getContactLookupUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.RawContacts.staticClass, global::android.provider.ContactsContract.RawContacts._getContactLookupUri10996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI10997;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.RawContacts.staticClass, _CONTENT_URI10997)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/raw_contact";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/raw_contact";
				}
			}
			public static int AGGREGATION_MODE_DEFAULT
			{
				get
				{
					return 0;
				}
			}
			public static int AGGREGATION_MODE_IMMEDIATE
			{
				get
				{
					return 1;
				}
			}
			public static int AGGREGATION_MODE_SUSPENDED
			{
				get
				{
					return 2;
				}
			}
			public static int AGGREGATION_MODE_DISABLED
			{
				get
				{
					return 3;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.RawContacts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$RawContacts"));
				global::android.provider.ContactsContract.RawContacts._newEntityIterator10995 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.RawContacts.staticClass, "newEntityIterator", "(Landroid/database/Cursor;)Landroid/content/EntityIterator;");
				global::android.provider.ContactsContract.RawContacts._getContactLookupUri10996 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.RawContacts.staticClass, "getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;");
				global::android.provider.ContactsContract.RawContacts._CONTENT_URI10997 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.RawContacts.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.RawContactsColumns_))]
		protected partial interface RawContactsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.RawContactsColumns))]
		protected sealed partial class RawContactsColumns_ : java.lang.Object, RawContactsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RawContactsColumns_()
			{
				InitJNI();
			}
			internal RawContactsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.RawContactsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$RawContactsColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class RawContactsColumnsConstants 
		{
			public static global::java.lang.String CONTACT_ID
			{
				get
				{
					return "contact_id";
				}
			}
			public static global::java.lang.String AGGREGATION_MODE
			{
				get
				{
					return "aggregation_mode";
				}
			}
			public static global::java.lang.String DELETED
			{
				get
				{
					return "deleted";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RawContactsEntity : java.lang.Object, BaseColumns, DataColumns, RawContactsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RawContactsEntity()
			{
				InitJNI();
			}
			internal RawContactsEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI11007;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.RawContactsEntity.staticClass, _CONTENT_URI11007)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/raw_contact_entity";
				}
			}
			public static global::java.lang.String DATA_ID
			{
				get
				{
					return "data_id";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.RawContactsEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$RawContactsEntity"));
				global::android.provider.ContactsContract.RawContactsEntity._CONTENT_URI11007 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.RawContactsEntity.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Settings : java.lang.Object, SettingsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Settings()
			{
				InitJNI();
			}
			internal Settings(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI11010;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.Settings.staticClass, _CONTENT_URI11010)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/setting";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/setting";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.Settings.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$Settings"));
				global::android.provider.ContactsContract.Settings._CONTENT_URI11010 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.Settings.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.SettingsColumns_))]
		protected partial interface SettingsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.SettingsColumns))]
		protected sealed partial class SettingsColumns_ : java.lang.Object, SettingsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SettingsColumns_()
			{
				InitJNI();
			}
			internal SettingsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.SettingsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$SettingsColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class SettingsColumnsConstants 
		{
			public static global::java.lang.String ACCOUNT_NAME
			{
				get
				{
					return "account_name";
				}
			}
			public static global::java.lang.String ACCOUNT_TYPE
			{
				get
				{
					return "account_type";
				}
			}
			public static global::java.lang.String SHOULD_SYNC
			{
				get
				{
					return "should_sync";
				}
			}
			public static global::java.lang.String UNGROUPED_VISIBLE
			{
				get
				{
					return "ungrouped_visible";
				}
			}
			public static global::java.lang.String ANY_UNSYNCED
			{
				get
				{
					return "any_unsynced";
				}
			}
			public static global::java.lang.String UNGROUPED_COUNT
			{
				get
				{
					return "summ_count";
				}
			}
			public static global::java.lang.String UNGROUPED_WITH_PHONES
			{
				get
				{
					return "summ_phones";
				}
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.StatusColumns_))]
		protected partial interface StatusColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.StatusColumns))]
		protected sealed partial class StatusColumns_ : java.lang.Object, StatusColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static StatusColumns_()
			{
				InitJNI();
			}
			internal StatusColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.StatusColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$StatusColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class StatusColumnsConstants 
		{
			public static global::java.lang.String PRESENCE
			{
				get
				{
					return "mode";
				}
			}
			public static global::java.lang.String PRESENCE_STATUS
			{
				get
				{
					return "mode";
				}
			}
			public static int OFFLINE
			{
				get
				{
					return 0;
				}
			}
			public static int INVISIBLE
			{
				get
				{
					return 1;
				}
			}
			public static int AWAY
			{
				get
				{
					return 2;
				}
			}
			public static int IDLE
			{
				get
				{
					return 3;
				}
			}
			public static int DO_NOT_DISTURB
			{
				get
				{
					return 4;
				}
			}
			public static int AVAILABLE
			{
				get
				{
					return 5;
				}
			}
			public static global::java.lang.String STATUS
			{
				get
				{
					return "status";
				}
			}
			public static global::java.lang.String PRESENCE_CUSTOM_STATUS
			{
				get
				{
					return "status";
				}
			}
			public static global::java.lang.String STATUS_TIMESTAMP
			{
				get
				{
					return "status_ts";
				}
			}
			public static global::java.lang.String STATUS_RES_PACKAGE
			{
				get
				{
					return "status_res_package";
				}
			}
			public static global::java.lang.String STATUS_LABEL
			{
				get
				{
					return "status_label";
				}
			}
			public static global::java.lang.String STATUS_ICON
			{
				get
				{
					return "status_icon";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class StatusUpdates : java.lang.Object, StatusColumns, PresenceColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static StatusUpdates()
			{
				InitJNI();
			}
			protected StatusUpdates(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getPresenceIconResourceId11034;
			public static int getPresenceIconResourceId(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.provider.ContactsContract.StatusUpdates.staticClass, global::android.provider.ContactsContract.StatusUpdates._getPresenceIconResourceId11034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getPresencePrecedence11035;
			public static int getPresencePrecedence(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.provider.ContactsContract.StatusUpdates.staticClass, global::android.provider.ContactsContract.StatusUpdates._getPresencePrecedence11035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI11036;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.StatusUpdates.staticClass, _CONTENT_URI11036)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/status-update";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/status-update";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.StatusUpdates.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$StatusUpdates"));
				global::android.provider.ContactsContract.StatusUpdates._getPresenceIconResourceId11034 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.StatusUpdates.staticClass, "getPresenceIconResourceId", "(I)I");
				global::android.provider.ContactsContract.StatusUpdates._getPresencePrecedence11035 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.StatusUpdates.staticClass, "getPresencePrecedence", "(I)I");
				global::android.provider.ContactsContract.StatusUpdates._CONTENT_URI11036 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.StatusUpdates.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.ContactsContract.SyncColumns_))]
		protected partial interface SyncColumns : BaseSyncColumns
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.ContactsContract.SyncColumns))]
		protected sealed partial class SyncColumns_ : java.lang.Object, SyncColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SyncColumns_()
			{
				InitJNI();
			}
			internal SyncColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.SyncColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$SyncColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class SyncColumnsConstants 
		{
			public static global::java.lang.String ACCOUNT_NAME
			{
				get
				{
					return "account_name";
				}
			}
			public static global::java.lang.String ACCOUNT_TYPE
			{
				get
				{
					return "account_type";
				}
			}
			public static global::java.lang.String SOURCE_ID
			{
				get
				{
					return "sourceid";
				}
			}
			public static global::java.lang.String VERSION
			{
				get
				{
					return "version";
				}
			}
			public static global::java.lang.String DIRTY
			{
				get
				{
					return "dirty";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class SyncState : java.lang.Object, android.provider.SyncStateContract.Columns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SyncState()
			{
				InitJNI();
			}
			internal SyncState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get11044;
			public static byte[] get(android.content.ContentProviderClient arg0, android.accounts.Account arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.provider.ContactsContract.SyncState.staticClass, global::android.provider.ContactsContract.SyncState._get11044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			}
			internal static global::MonoJavaBridge.MethodId _set11045;
			public static void set(android.content.ContentProviderClient arg0, android.accounts.Account arg1, byte[] arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.SyncState.staticClass, global::android.provider.ContactsContract.SyncState._set11045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _getWithUri11046;
			public static global::android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.accounts.Account arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.SyncState.staticClass, global::android.provider.ContactsContract.SyncState._getWithUri11046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.util.Pair;
			}
			internal static global::MonoJavaBridge.MethodId _newSetOperation11047;
			public static global::android.content.ContentProviderOperation newSetOperation(android.accounts.Account arg0, byte[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.ContactsContract.SyncState.staticClass, global::android.provider.ContactsContract.SyncState._newSetOperation11047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation;
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "syncstate";
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI11049;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.SyncState.staticClass, _CONTENT_URI11049)) as android.net.Uri;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.ContactsContract.SyncState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract$SyncState"));
				global::android.provider.ContactsContract.SyncState._get11044 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.SyncState.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B");
				global::android.provider.ContactsContract.SyncState._set11045 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.SyncState.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V");
				global::android.provider.ContactsContract.SyncState._getWithUri11046 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.SyncState.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/Pair;");
				global::android.provider.ContactsContract.SyncState._newSetOperation11047 = @__env.GetStaticMethodIDNoThrow(global::android.provider.ContactsContract.SyncState.staticClass, "newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.ContactsContract.SyncState._CONTENT_URI11049 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.SyncState.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _ContactsContract11050;
		public ContactsContract()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.ContactsContract.staticClass, global::android.provider.ContactsContract._ContactsContract11050);
			Init(@__env, handle);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "com.android.contacts";
			}
		}
		internal static global::MonoJavaBridge.FieldId _AUTHORITY_URI11052;
		public static global::android.net.Uri AUTHORITY_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.ContactsContract.staticClass, _AUTHORITY_URI11052)) as android.net.Uri;
			}
		}
		public static global::java.lang.String CALLER_IS_SYNCADAPTER
		{
			get
			{
				return "caller_is_syncadapter";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.ContactsContract.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/ContactsContract"));
			global::android.provider.ContactsContract._ContactsContract11050 = @__env.GetMethodIDNoThrow(global::android.provider.ContactsContract.staticClass, "<init>", "()V");
			global::android.provider.ContactsContract._AUTHORITY_URI11052 = @__env.GetStaticFieldIDNoThrow(global::android.provider.ContactsContract.staticClass, "AUTHORITY_URI", "Landroid/net/Uri;");
		}
	}
}
